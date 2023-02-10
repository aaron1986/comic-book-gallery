using comic_book_gallery.Models;
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

            //Instantiating ComBook model object
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing SpiderMan",
                IssueNumber = 700,
                DescriptionHtml = "<p> Final Issue </p>",

                Artists = new Artist[]

                  {
                  new Artist()
                    {
                    Name ="Dan Slott",
                    Role = "Script"
                  },
                  new Artist()
                    {
                    Name ="Humberto Ramos",
                    Role = "Pencils"
                  },
                  new Artist()
                    {
                    Name ="Victor Olazba",
                    Role = "Inks"
                  },
                  new Artist()
                    {
                    Name ="Edger dalgado",
                    Role = "Colours"
                  },
                  new Artist()
                    {
                    Name ="Chris eliopulars",
                    Role = "Letters"
                  }
                  }
            }; //End of Artists Array
            return View(comicBook);
        }
    }
}