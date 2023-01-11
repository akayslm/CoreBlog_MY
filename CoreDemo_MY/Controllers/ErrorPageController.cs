using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
