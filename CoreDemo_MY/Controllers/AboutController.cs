using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
