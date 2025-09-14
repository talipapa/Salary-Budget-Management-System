using Domain.Salaries;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class CoreDbContext(DbContextOptions<CoreDbContext> options) : DbContext(options)
    {
        public DbSet<Salary> Salary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("core");

            base.OnModelCreating(modelBuilder);
        }
    }
}
