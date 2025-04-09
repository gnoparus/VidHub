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

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4}):range(2000, 2025)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content("ByReleaseYear - Year / Month: " + year + "/" + month);
        }
    }
}