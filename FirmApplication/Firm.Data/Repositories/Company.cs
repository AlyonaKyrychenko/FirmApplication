using Firm.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Repositories
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; }
        public List<Foreman> Foremen { get; }
        public List<Manager> Managers { get; }


        public Company(string name)
        {
            Name = name;
            Workers = new List<Worker>();
            Foremen = new List<Foreman>();
            Managers = new List<Manager>();
        }


        public static Company operator +(Company company, Staff<Worker> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var worker = new Staff<Worker>();
                var workerToChange = worker.GetById(entity.Id);
                workerToChange.CompanyName = company.Name;
                ctx.SaveChanges();
                return company;
            };
        }
        public static Company operator +(Company company, Staff<Foreman> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var foreman = new Staff<Foreman>();
                var foremanToChange = foreman.GetById(entity.Id);
                foremanToChange.CompanyName = company.Name;
                ctx.SaveChanges();
                return company;
            };
        }
        public static Company operator +(Company company, Staff<Manager> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var manager = new Staff<Manager>();
                var managerToChange = manager.GetById(entity.Id);
                managerToChange.CompanyName = company.Name;
                ctx.SaveChanges();
                return company;
            };
        }
        public static Company operator -(Company company, Staff<Worker> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var worker = new Staff<Worker>();
                var workertToChange = worker.GetById(entity.Id);
                entity.CompanyName = null;
                ctx.SaveChanges();
                return company;
            };
        }
        public static Company operator -(Company company, Staff<Foreman> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var worker = new Staff<Foreman>();
                var workertToChange = worker.GetById(entity.Id);
                entity.CompanyName = null;
                ctx.SaveChanges();
                return company;
            };
        }
        public static Company operator -(Company company, Staff<Manager> entity)
        {
            using (var ctx = new FirmContext("Default"))
            {
                var worker = new Staff<Manager>();
                var workertToChange = worker.GetById(entity.Id);
                entity.CompanyName = null;
                ctx.SaveChanges();
                return company;
            };
        }

        public void ShowAll(string companyName)
        {
            var allWorkers = new Staff<Worker>();
            var workerList = allWorkers.GetAll(x => x.CompanyName == companyName).ToList();
            Console.WriteLine("Список всех рабочих:");
            Console.WriteLine(workerList);

            var allForemen = new Staff<Foreman>();
            var foremanList = allForemen.GetAll(x => x.CompanyName == companyName).ToList();
            Console.WriteLine("Список всех бригадиров:");
            Console.WriteLine(foremanList);

            var allManagers = new Staff<Manager>();
            var managerList = allManagers.GetAll(x => x.CompanyName == companyName).ToList();
            Console.WriteLine("Список всех менеджеров:");
            Console.WriteLine(managerList);
        }

        public int Counting(string position)
        {
            if(position == "Рабочий")
            {
                var allWorkers = new Staff<Worker>();
                var workerList = allWorkers.GetAll(x => x.Postition == position).Count();
                return workerList;
            }
            else if(position == "Бригадир")
            {
                var allForemen = new Staff<Foreman>();
                var foremanList = allForemen.GetAll(x => x.Postition == position).Count();
                return foremanList;
            }
            else if(position == "Менеджер")
            {
                var allManagers = new Staff<Manager>();
                var managerList = allManagers.GetAll(x => x.Postition == position).Count();
                return managerList;
            }
            else
            {
                return 0;
            }
        }

        public void Show(string position)
        {
            if (position == "Рабочий")
            {
                var allWorkers = new Staff<Worker>();
                var workerList = allWorkers.GetAll(x => x.Postition == position).ToList();
                Console.WriteLine("Список всех рабочих:");
                Console.WriteLine(workerList);
            }
            else if (position == "Бригадир")
            {
                var allForemen = new Staff<Foreman>();
                var foremanList = allForemen.GetAll(x => x.Postition == position).ToList();
                Console.WriteLine("Список всех бригадиров:");
                Console.WriteLine(foremanList);
            }
            else if (position == "Менеджер")
            {
                var allManagers = new Staff<Manager>();
                var managerList = allManagers.GetAll(x => x.Postition == position).ToList();
                Console.WriteLine("Список всех менеджеров:");
                Console.WriteLine(managerList);
            }
        }
    }
}
