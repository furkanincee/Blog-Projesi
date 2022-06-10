﻿using BusinessLayer;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Projesi.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
