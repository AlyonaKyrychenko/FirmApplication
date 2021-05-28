using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Repositories
{
    public class Worker : Staff<Worker>
    {
        public Worker(int id, string fullName, string position, int monthsOfExperience, string companyName)
        {
            this.Id = Id;
            this.FullName = fullName;
            this.Postition = position;
            this.MonthsOfExperience = monthsOfExperience;
            this.CompanyName = companyName;
        }

        public void Work()
        {
            Console.WriteLine("Выпуск продукции работником.");
        }
    }
}
