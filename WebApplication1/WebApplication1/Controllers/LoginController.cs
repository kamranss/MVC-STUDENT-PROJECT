using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {


        public IActionResult login( Login loginmodel)
        {

            ViewData["ExcludeLayout"] = true;
            string username = loginmodel.Username;
            string password = loginmodel.Password;

            Login login = new Login()
            {
                Username = "admin@email.com",
                Password = "admin"
            };
            
            if (!(login.Username == username && login.Password == password))
            {
                Console.WriteLine("hey working");
               return RedirectToAction("Index", "Home");
            }
            return View();



        }
    }
}
