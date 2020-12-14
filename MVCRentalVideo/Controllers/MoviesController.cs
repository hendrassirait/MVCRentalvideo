using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRentalVideo.Models; 

namespace MVCRentalVideo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            ViewBag.Name = "Tes";
            return View();
        }
    }
}