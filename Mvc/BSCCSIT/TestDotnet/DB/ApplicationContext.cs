using Microsoft.EntityFrameworkCore;
using TestDotnet.Models;

namespace TestDotnet.DB
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Students> Students { get; set; }
    }
}
