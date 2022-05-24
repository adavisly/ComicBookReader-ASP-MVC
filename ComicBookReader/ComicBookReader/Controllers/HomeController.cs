using ComicBookReader.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ComicBookReader.Controllers
{
    public class HomeController : Controller
    {
        AppDBContext db;

        public HomeController(AppDBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.ComicBooks.ToList());
        }

        public IActionResult ComicBook(int id = 1)
        {
            ComicBook comicBook = db.ComicBooks.Find(id);
            return View(comicBook);
        }

        [Authorize]
        public IActionResult Authors()
        {
            return View(db.Authors.ToList());
        }

        public IActionResult Chapters()
        {
            return View(db.Chapters.ToList());
        }

        public IActionResult Genres()
        {
            return View(db.Genres.ToList());
        }

        public IActionResult ComicPages()
        {
            return View(db.ComicPages.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
