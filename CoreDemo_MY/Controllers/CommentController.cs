﻿using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo_MY.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CoomentStatus = true;
            p.BlogID = 2;
            cm.CommentAdd(p);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
           var values =  cm.GetList(id);
            return PartialView(values);
        }
    }
}
