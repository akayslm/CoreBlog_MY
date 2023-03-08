using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
