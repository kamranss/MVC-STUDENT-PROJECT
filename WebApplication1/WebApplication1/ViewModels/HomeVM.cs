using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public Group Group { get; set; }

        public HomeVM()
        {
        }

        public HomeVM(List<Student> students, Group group)
        {
            Students = students;
            Group = group;
        }
    }
}
