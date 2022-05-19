using Microsoft.AspNetCore.Mvc;
using System;

namespace ComicBookReader.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
