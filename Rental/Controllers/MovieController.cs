using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental.Models;
using Rental.Models.Movie;

namespace Rental.Controllers
{

    //You can apply some of the route here like :
    // [Route(Home)]
    //amnd on every controller you can just skip Home word or Movie ... 
    public class MovieController : Controller
    {
        // GET: Movie/Random
        [Route("~/movies")]
        [Route("movies/{id}")]
        public ActionResult Movies(int? id)
        {
            IRentableMovie[] movieSet ;
            movieSet  = new IRentableMovie[5];

            for (int i = 0; i < movieSet.Length; i++)
            {
                movieSet[i] = new RentableMovie()
                {
                    ID = i,
                    Title = "Movie Num : " + i.ToString()
                };
            }
            //a better way to do it next line ...
            /*
            if (id == null)
                id = 1;
            else
                movieteset.ID = (int)id;
            */
            
            //if id is null give the value of {0} no need for an if statement ..
            //movieteset.Title = "Zombie" + (id ?? 0);



            
            
            return View(movieSet[0]);
        }

        public ContentResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/durotion/{hours:range(0,20)}/{minutes:regex(\\d{2}):range(0,59)}")]
        public ContentResult ByDurotion(int hours, int minutes)
        {
            return Content(hours + "/" + minutes);
        }


    }
}