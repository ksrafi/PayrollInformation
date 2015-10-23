using System.Linq;
using PayrollInformation.Concrete;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public class SalariesRepository : ISalariesRepository
    {
        private readonly PayrollInformationDbContext _dbContext = new PayrollInformationDbContext();
        public IQueryable<Salary> Salaries
        {
            get { return _dbContext.Salaries; }
        }
    }
}
