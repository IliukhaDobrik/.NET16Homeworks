using Microsoft.AspNetCore.Mvc;
using Home14.Models;

namespace Home14.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var book = new BookViewModel { Title = "La Divina Commedia", Author = "Dante Alighieri", CountOfPages = 798};

            return View(book);
        }
    }
}
