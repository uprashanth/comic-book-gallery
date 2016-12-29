using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Script", Role = "Dan Slott"},
                    new Artist() { Name = "Pencils", Role = "Humberto Ramos"},
                    new Artist() { Name = "Inks", Role = "Victor Olazaba"},
                    new Artist() { Name = "Colors", Role = "Edgar Delgado"},
                    new Artist() { Name = "Letters", Role = "Chris Eliopoulos"}
                }
            };
            
            return View(comicBook);
        }
    }
}