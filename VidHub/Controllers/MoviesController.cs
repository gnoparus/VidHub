using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidHub.Models;

namespace VidHub.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Title = "The Keng 2022!" };

            //return View(movie);
            //return Content("Hello Keng");
            //return HttpNotFound("Movie not found");
            //return new EmptyResult();

            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}