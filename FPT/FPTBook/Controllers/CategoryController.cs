using Microsoft.AspNetCore.Mvc;

namespace FPTBook.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
