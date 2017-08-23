using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviesite.Models;


namespace Moviesite.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View("New", movie);
        }

            public ActionResult New()
        {
            var movie = new Movie();
            
            return View(movie);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);

            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Quantity = movie.Quantity;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Description = movie.Description;
                movieInDb.PriceOfMovie = movie.PriceOfMovie;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }
        // GET: All the Movies in the database 
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList().OrderBy(c => c.Name).ThenBy(c => c.ReleaseDate);
          
            return View(movies);
        }
        // GET: Details on specific movie 
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
           
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        // GET: List of popular movie
        public ActionResult Popular()
        {
            var movies = _context.Movies.ToList().OrderBy(c => c.Name).ThenBy(c => c.ReleaseDate);

            var popularMovies = new List<Movie>();
            
            foreach (var movie in movies)
            {
                if (movie.NumberOfRentalThisYear > 20)
                {
                    popularMovies.Add(movie);
                }
            }
            var sortedMovies = popularMovies.OrderBy(c => c.NumberOfRentalThisYear).ThenBy(c => c.Name);

            return View(sortedMovies);
        }
        public ActionResult NewMovie()
        {
            var movies = _context.Movies.ToList();
            var newMovies = new List<Movie>();
            int DateCutoff = -180;

            DateTime startDate = DateTime.Now.AddDays(DateCutoff);

            foreach (var movie in movies)
            {
                if(movie.ReleaseDate >= startDate && movie.ReleaseDate < DateTime.Now)
                {
                    newMovies.Add(movie);
                }
            }
   
            return View(newMovies);
        }
    }
}

