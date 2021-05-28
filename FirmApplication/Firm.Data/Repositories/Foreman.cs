using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Repositories
{
    public class Foreman : Staff<Foreman>
    {
        public Foreman(int id, string fullName, string position, int monthsOfExperience, string companyName)
        {
            this.Id = Id;
            this.FullName = fullName;
            this.Postition = position;
            this.MonthsOfExperience = monthsOfExperience;
            this.CompanyName = companyName;
        }

        public void Work()
        {
            Console.WriteLine("Закупка материалов бригадиром.");
        }

        public void Checking()
        {
            Console.WriteLine("Выполнение проверки рабочих бригадиром.");
        }
    }
}
