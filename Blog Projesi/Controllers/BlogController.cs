using Microsoft.AspNetCore.Mvc;

namespace Blog_Projesi.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
