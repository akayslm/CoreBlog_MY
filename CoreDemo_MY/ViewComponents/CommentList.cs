using CoreDemo_MY.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                     ID = 1,
                     UserName="Selim"
                },
                new UserComment {
                    ID = 2,
                    UserName="Ceren"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Meryem"
                }
            };
            return View(commentValues);
        }
    }
}
