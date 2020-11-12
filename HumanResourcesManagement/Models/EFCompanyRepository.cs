using System.Linq;

namespace HumanResourcesManagement.Models
{
    public class EFCompanyRepository : ICompanyRepository
    {
        private CompanyDbContext context;

        public EFCompanyRepository(CompanyDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
