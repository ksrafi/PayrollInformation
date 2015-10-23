using System.Linq;
using PayrollInformation.Concrete;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public class RolesRepository : IRolesRepository
    {
        private readonly PayrollInformationDbContext _dbContext = new PayrollInformationDbContext();
        public IQueryable<Role> Roles
        {
            get { return _dbContext.Roles; }
        }
    }
}
