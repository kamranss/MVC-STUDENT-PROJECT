using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "shkjskjs";
        }

        public IActionResult Index2()
        {
            ViewResult result = View();
            result.ViewName = "Index2";
            return result;
            //return View();
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
