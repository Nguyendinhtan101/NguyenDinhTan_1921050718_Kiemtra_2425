namespace Baithi.Data
{
    using Microsoft.EntityFrameworkCore;
    using Baithi.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Demo> Demo { get; set; }
    }
}