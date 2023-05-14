using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        // DbSet is the class which designed to map property and create sql table 
        public DbSet<Student> Students { get; set; }
        public DbSet<Models.Group> Groups { get; set; }

        public DbSet<Contact> Contacts { get; set; }

    }
}
