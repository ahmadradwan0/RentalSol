using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class HomeController : Controller
    {

        //home/index
        public ContentResult Index(int? id,string sortby)
        {

           
            return Content(String.Format("Id={0}&sortby={1}",id,sortby));
        }

    }
}