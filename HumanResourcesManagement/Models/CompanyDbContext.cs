using Microsoft.EntityFrameworkCore;

namespace HumanResourcesManagement.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
