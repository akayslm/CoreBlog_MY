using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }
    }
}
