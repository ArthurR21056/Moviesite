using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviesite.Models;

namespace Moviesite.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);

            if(customer == null) { return HttpNotFound();  }

            var customerViewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipType
            };
            return View("New", customerViewModel);
        }

        //Give a empty movie object to the view to be edited
        public ActionResult New()
        {
            var membershipType = _context.MembershipType;
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipType
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipType.ToList()
                };

                return View("New", viewModel);
            }
            if (customer.Id == 0)
            {
                _context.Customer.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipType = customer.MembershipType;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customer.ToList();

            foreach (var customer in customers)
            {

            }
            return View(customers);
        }
        // GET: Customer details base on id
        public ActionResult Detail(int id)
        {
            var customers = _context.Customer.SingleOrDefault(c => c.Id == id);
            
            if (customers == null){ return HttpNotFound(); }
             
            return View(customers);
        }

    }
}
