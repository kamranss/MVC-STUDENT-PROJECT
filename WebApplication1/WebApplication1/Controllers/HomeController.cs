using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Web;
using Microsoft.Extensions.Configuration;
using WebApplication1.DAL;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _appDbContext;


        public HomeController(IConfiguration config, AppDbContext appDbContext)
        {
            _configuration = config;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {

            Student student1 = _appDbContext.Students.FirstOrDefault(p => p.Id == 2); // getting data from db using method to get only one --- default it returns first data or 0
            var name = _configuration.GetSection("Name").Value;  // getting data from apsetting.json file

            ViewData["ExcludeCSS"] = true;

            Student student = new Student()
            {
                Id = 1,
                Name = "Kamran",
                Age = 12,
                GroupId = 1,
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Test",
                Age = 1,
                GroupId = 1,
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Test",
                Age = 1,
                GroupId = 1,
            };

            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student2);
            studentList.Add(student3);

            Group Group = new Group()
            {
                Id = 1,
                Name = "Test",
            };


            HomeVM HomeVM = new HomeVM()
            {
                Students = studentList,
                Group = Group
            };

            // it receives any data list and links to view in the view without using model we can access this data  
            ViewBag.Name = "Kamran";
            ViewData["Name"] = "Kamran";
            TempData["Name"] = "Kamran";  // TempData is accesible when we use redirect but  ViewBag ViewData not
            return View(HomeVM);

        }

        [HttpPost]
        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            //Response.Redirect("/Login/login");
            return RedirectToAction("login", "Login");
        }



        public IActionResult Index2()
        {
            //ViewResult result = View();
            //result.ViewName = "Index2";
            //return result;

            Student student = new Student()
            {
                Id = 1,
                Name = "Test",
                Age = 1,
                GroupId = 1,
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Test",
                Age = 1,
                GroupId = 1,
            };
            Student student3 = new Student()
            {   Id = 3,
                Name = "Test",
                Age = 1,
                GroupId = 1,
            };

            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student2);
            studentList.Add(student3);

            Group Group = new Group()
            {
                Id = 1,
                Name = "Test",
            };


            HomeVM HomeVM = new HomeVM()
            {
                Students = studentList,
                Group = Group
            };

            return View(HomeVM);
        }

     
        // this approach for other side they will use url to get image
        public IActionResult index3()
        {
            return File("image", "photo-1.jfif");
        }

        public IActionResult index4()
        {
            return File("~/image/photo-1.jfif", "image/jfif");
        }

        public IActionResult index5()
        {
            return Json(new { name = "Ka", age = 5 });
        }
    }
}
