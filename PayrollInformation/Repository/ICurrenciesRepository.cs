using System.Linq;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public interface ICurrenciesRepository
    {
        IQueryable<Currency> Currencies { get; }
    }
}
