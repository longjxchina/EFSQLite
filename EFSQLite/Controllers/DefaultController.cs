using EFSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFSQLite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            MovieDbContext db = new MovieDbContext();

            db.Movies.Add(new Movie
            {

                Id = System.Guid.NewGuid().ToString(),
                MovieName = DateTime.Now.Ticks.ToString()
            });
            db.SaveChanges();

            return View(db.Movies);
        }
    }
}