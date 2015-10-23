using System.Linq;
using PayrollInformation.Concrete;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public class CurrenciesRepository : ICurrenciesRepository
    {
        private readonly PayrollInformationDbContext _dbContext = new PayrollInformationDbContext();
        public IQueryable<Currency> Currencies
        {
            get { return _dbContext.Currencies; }
        }
    }
}
