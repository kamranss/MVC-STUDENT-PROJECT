using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult GroupIndex()
        {
            ViewData["ExcludeCSS"] = true;

            Group group1 = new Group()
            {
                Id = 1,
                Name = "A"
            };
            Group group2 = new Group()
            {
                Id = 2,
                Name = "B"
            };
            Group group3 = new Group()
            {
                Id = 3,
                Name = "C",
            };

            List<Group> groupList = new List<Group>();
            groupList.Add(group1);
            groupList.Add(group2);
            groupList.Add(group3);

            return View(groupList);
        }
        public IActionResult GroupDetail(int id)
        {

            return View();
        }
    }
}
