using DemoEF1.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEF1.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
