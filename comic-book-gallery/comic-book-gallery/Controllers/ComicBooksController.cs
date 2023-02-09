using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing SpiderMan";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazba",
                "Colours: Edger dalgado",
                "Letters: Chris eliopulars"

            };
            return View();
        }
    }
}