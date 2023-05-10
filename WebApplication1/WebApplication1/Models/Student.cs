namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        public Student()
        {
        }

        public Student(int ıd, string name, int age, int groupId)
        {
            Id = ıd;
            Name = name;
            Age = age;
            GroupId = groupId;
        }
    }
}
