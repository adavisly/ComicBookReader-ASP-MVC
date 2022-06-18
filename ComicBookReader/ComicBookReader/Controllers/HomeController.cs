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
using System.IO;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Web.Helpers;
using System.Drawing;
using System.Web;

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
            List<ComicBook_User> cb_users = db.ComicBook_Users.Where(cbu => cbu.ComicBookId == id).ToList();
            ViewBag.CB_Users = cb_users;

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

        [Authorize]
        [HttpPost]
        public IActionResult SendReview(int mark, int cbId, string reviewValue)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = db.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
                int userId = user.UserId;
                ComicBook_User cb_user = db.ComicBook_Users.Find(cbId, userId);
                if (cb_user == null)
                {
                    db.ComicBook_Users.Add(new ComicBook_User
                    {
                        ComicBookId = cbId,
                        UserId = userId,
                        ComicBookMark = mark,
                        ComicBookReview = reviewValue
                    });
                    db.SaveChanges();
                }
                else
                {
                    cb_user.ComicBookReview = reviewValue;
                    cb_user.ComicBookMark = mark;
                    db.ComicBook_Users.Update(cb_user);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("ComicBook", new {id = cbId});
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddStatus(int mark, int cbId, string reviewValue)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = db.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
                int userId = user.UserId;
                ComicBook_User cb_user = db.ComicBook_Users.Find(cbId, userId);
                if (cb_user == null)
                {
                    db.ComicBook_Users.Add(new ComicBook_User
                    {
                        ComicBookId = cbId,
                        UserId = userId,
                        ComicBookMark = mark,
                        ComicBookReview = reviewValue
                    });
                    db.SaveChanges();
                }
                else
                {
                    cb_user.ComicBookReview = reviewValue;
                    cb_user.ComicBookMark = mark;
                    db.ComicBook_Users.Update(cb_user);
                    db.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult RecognizeText(int id)
        {
            ComicPage cp = db.ComicPages.Find(id);
            //string lang = "eng";
            string filePath = "wwwroot" + cp.PageImage;
            ViewBag.Preview = "#";
            /*
            Tesseract tesseract = new Tesseract("wwwroot/TrainedData",
                        lang, OcrEngineMode.TesseractLstmCombined);

            tesseract.SetImage(new Image<Bgr, byte>(filePath));

            tesseract.Recognize();

            ViewBag.Text = tesseract.GetUTF8Text();

            tesseract.Dispose();
            */
            return View(cp);
        }


        [HttpPost]
        public IActionResult CropImage(int x1, int y1, int x2, int y2, int w, int h, int imgW, int imgH, int cpId)
        {
            string lang = "none";

            ComicPage cp = db.ComicPages.Find(cpId);

            Chapter ch = db.Chapters.Find(cp.ChapterId);

            ComicBook cb = db.ComicBooks.Find(ch.ComicBookId);

            if (cb.ComicBookLanguage == "English")
                lang = "eng";
            else if (cb.ComicBookLanguage == "Russian")
                lang = "rus";
            else if (cb.ComicBookLanguage == "Japanese")
                lang = "jpn";
            else lang = "none";

            if (lang != "none")
            {
                string newFileName = Guid.NewGuid() + ".jpg";
                string newFilePath = "wwwroot/img/crop/";

                string filePath = Path.Combine(newFilePath, newFileName);

                System.IO.File.Copy("wwwroot" + cp.PageImage, filePath);
                Image orgImg = Image.FromFile(filePath);
                Rectangle CropArea = new Rectangle(
                    Convert.ToInt32(x1),
                    Convert.ToInt32(y1),
                    Convert.ToInt32(w),
                    Convert.ToInt32(h));
                Bitmap bitMap = new Bitmap(CropArea.Width, CropArea.Height);
                using (Graphics g = Graphics.FromImage(bitMap))
                {
                    g.DrawImage(orgImg, new Rectangle(0, 0, bitMap.Width, bitMap.Height), CropArea, GraphicsUnit.Pixel);
                }
                var cropFileName = "crop_" + newFileName;
                var cropFilePath = Path.Combine(newFilePath, cropFileName);
                bitMap.Save(cropFilePath);
                //Response.Redirect("~/UploadImages/" + cropFileName, false);

                ViewBag.Preview = "/img/crop/" + cropFileName;

                Tesseract tesseract = new Tesseract("wwwroot/TrainedData",
                            lang, OcrEngineMode.TesseractLstmCombined);

                tesseract.SetImage(new Image<Bgr, byte>(cropFilePath));

                tesseract.Recognize();

                string text = tesseract.GetUTF8Text();
                ViewBag.Text = text;

                tesseract.Dispose();
            }

            

            return View("RecognizeText", cp);
        }

        private string ProcessImage(string croppedImage)
        {
            string filePath = String.Empty;
            try
            {
                string base64 = croppedImage;
                byte[] bytes = Convert.FromBase64String(base64.Split(',')[1]);
                filePath = "/croppedImages/Photo/img" + Guid.NewGuid() + ".jpg";
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
            return filePath;
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
