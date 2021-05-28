using Firm.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Repositories
{
    public class Staff<TEntity> : IStaff<TEntity>
         where TEntity : class
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int MonthsOfExperience { get; set; }
        public string Postition { get; set; }

        public string CompanyName { get; set; }
        public Company Company { get; set; }


        private static readonly DbSet<TEntity> _dbSet;

        public TEntity GetById(int id)
        {
            using (var ctx = new FirmContext("Default"))
            {
                return _dbSet.Find(id);
            };
        }

        public IReadOnlyCollection<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            using (var ctx = new FirmContext("Default"))
            {
                return _dbSet.AsNoTracking().Where(predicate).ToList();
            };
        }

        public bool IsStaffOnCompany(int id, string companyName)
        {
            using (var ctx = new FirmContext("Default"))
            {
                bool isInCompany = false;

                var staff = _dbSet.Find(id);

                if (staff == null)
                {
                    Console.WriteLine("Такого сотрудника не существует");
                    return isInCompany;
                }
                else if (CompanyName == companyName)
                {
                    isInCompany = true;
                    return isInCompany;
                }
                return isInCompany;
            };
        }
    }
}
