﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo_MY.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }     
        
        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBM(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text=x.CategoryName,
                                                       Value=x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;    
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            //BlogValidator bv = new BlogValidator();
            //ValidationResult results = bv.Validate(p);
            //if (results.IsValid)
            //{
            //    p.BlogStatus = true;
            //    p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //    p.WriterID = 1;
            //    bm.TAdd(p);

            //    return RedirectToAction("BlogListByWriter", "Blog");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            return View();            
        }
    }
}
