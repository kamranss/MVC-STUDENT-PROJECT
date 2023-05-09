namespace WebApplication1.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Group()
        {
        }

        public Group(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}
