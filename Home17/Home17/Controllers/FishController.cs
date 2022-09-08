using Microsoft.AspNetCore.Mvc;
using Home17.Models;

namespace Home17.Controllers
{
    public class FishController : Controller
    {
        private static readonly List<Fish> fishList = new List<Fish>
        {
            new Fish {Name = "Карась", Weight = 200.6, Speed = 7},
            new Fish {Name = "Карп", Weight = 469.7, Speed = 8},
            new Fish {Name = "Щука", Weight = 123.4, Speed = 9.5}
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTransportByViewBag()
        {
            ViewBag.Fish = fishList;

            return View();
        }

        public IActionResult DataTransportByViewData()
        {
            ViewData["Fish"] = fishList;

            return View();
        }

        public IActionResult DataTransportByModel()
        {
            ViewData["Name"] = "Карп";
            ViewBag.Weight = 10;

            return View(fishList);
        }

        public IActionResult ViewWithSeparateLayout()
        {
            return View(fishList);
        }
    }
}
