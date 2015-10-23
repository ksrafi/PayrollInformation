using System.Linq;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public interface ISalariesRepository
    {
        IQueryable<Salary> Salaries { get; }
    }
}
