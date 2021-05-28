using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Contracts
{
    public interface IStaff<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IReadOnlyCollection<TEntity> GetAll(Func<TEntity, bool> predicate);
        bool IsStaffOnCompany(int id, string companyName);
    }
}
