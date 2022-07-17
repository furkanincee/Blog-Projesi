using Microsoft.AspNetCore.Mvc;

namespace Blog_Projesi.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentList()
        {
            return PartialView();
        }
    }
}
