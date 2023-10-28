using Microsoft.EntityFrameworkCore;
using School_Administrator.Models;

namespace School_Administrator.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }  
    }
}
