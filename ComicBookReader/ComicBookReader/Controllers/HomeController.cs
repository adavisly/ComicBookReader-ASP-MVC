using ComicBookReader.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;


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

        public IActionResult ComicBook(int id)
        {
            ComicBook comicBook = db.ComicBooks.Find(id);
            comicBook.Chapters = db.Chapters.Where(ch => ch.ComicBookId == id).ToList();
            comicBook.Authors = db.Authors.Include(a => a.ComicBooks).ToList();
            comicBook.Genres = db.Genres.Include(g => g.ComicBooks).ToList();
            return View(comicBook);
        }

        public IActionResult ComicChapter(int id)
        {
            Chapter chapter = db.Chapters.Find(id);
            int cbId = chapter.ComicBookId;
            ComicBook comicBook = db.ComicBooks.Find(cbId);
            comicBook.Chapters = db.Chapters.Where(ch => ch.ComicBookId == cbId).ToList();
            int chaptersCount = comicBook.Chapters.Count();
            int firstChapter = comicBook.Chapters.FirstOrDefault().ChapterId;
            ViewBag.ChapterCount = chaptersCount;
            ViewBag.FirstChapter = firstChapter;
            chapter.ComicPages = db.ComicPages.Where(cp => cp.ChapterId == id).OrderBy(cp => cp.PageNumber).ToList();
            return View(chapter);
        }

        public string TextRecognition(string img)
        {

            return img;
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
