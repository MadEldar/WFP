using System.Linq;

namespace HumanResourcesManagement.Models
{
    public interface ICompanyRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
