using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) { }
        public DbSet <Category> WebApplication1 { get; set; }
    }
}
