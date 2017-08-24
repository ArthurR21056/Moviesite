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

        //Give a empty movie object to the view to be edited
        public ActionResult New()
        {
            var membershipType = _context.MembershipType;
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipType
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customer.ToList();

            return View(customers);
        }
        // GET: Customer details base on id
        public ActionResult Detail(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);
            
            if (customer == null){ return HttpNotFound(); }
             
            return View(customer);
        }

    }
}
