using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentIndex()
        {

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


            return View(HomeVM);
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
        public IActionResult GetStudentsWithGroupid(int id)
        {
            return View();
        }
    }
}
