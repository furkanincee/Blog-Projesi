using Microsoft.AspNetCore.Mvc;

namespace Blog_Projesi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
