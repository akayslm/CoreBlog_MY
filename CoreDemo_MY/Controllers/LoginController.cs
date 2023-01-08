using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
