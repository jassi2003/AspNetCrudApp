using Microsoft.EntityFrameworkCore;

namespace formApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<FormModel> Forms { get; set; }
    }
}