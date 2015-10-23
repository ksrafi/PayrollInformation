using System.Linq;
using PayrollInformation.Entities;

namespace PayrollInformation.Repository
{
    public interface IRolesRepository
    {
        IQueryable<Role> Roles { get; }
    }
}
