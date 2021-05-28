using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Repositories
{
    public class Manager : Staff<Manager>
    {
        public Manager(int id, string fullName, string position, int monthsOfExperience, string companyName)
        {
            this.Id = Id;
            this.FullName = fullName;
            this.Postition = position;
            this.MonthsOfExperience = monthsOfExperience;
            this.CompanyName = companyName;
        }

        public void Work()
        {
            Console.WriteLine("Сбор заказов менеджером.");
        }

        public void GiveAnAssignment()
        {
            Console.WriteLine("Выдача заданий менеджером.");
        }
    }
}
