using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental.Models;
using Rental.Models.Movie;

namespace Rental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            IRentableMovie movieteset = new BlueRayMovie();
            movieteset.ID = 1;
            movieteset.Title = "Zombie";



            
            
            return View(movieteset);
        }
    }
}