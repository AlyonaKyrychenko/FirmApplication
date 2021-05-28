using Firm.Data.Contracts;
using Firm.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    public class ApplicationStart
    {
        private readonly IStaff<Worker> _worker;
        private readonly IStaff<Manager> _manager;
        private readonly IStaff<Foreman> _foreman;
        private readonly ICompany _company;

        public ApplicationStart(IStaff<Worker> worker, IStaff<Manager> manager, IStaff<Foreman> foreman, ICompany company)
        {
            _worker = worker;
            _manager = manager;
            _foreman = foreman;
            _company = company;
        }

        public void Run()
        {
            Company company = new Company("Name");

            Console.WriteLine("РЕЗУЛЬТАТ ВЫПОЛНЕНИЯ ВСЕХ МЕТОДОВ РАБОЧЕГО");
            Console.WriteLine("Добавление рабочего в фирму:");
            company += new Worker(10, "WorkerName", "Рабочий", 12, "CompanyName");

            Console.WriteLine("Присутствует ли сотрудник в компании:");
            _worker.IsStaffOnCompany(10, "Name");

            Console.WriteLine("Получение всех сотрудников типа Worker:");
            _company.Show("Рабочий");

            Console.WriteLine("Получение количества сотрудников типа Worker:");
            _company.Counting("Рабочий");

            Console.WriteLine("Результаты выполнения метода класса Worker:");
            var randomWorker = new Worker(20, "RandomWorkerName", "Рабочий", 17, "RandomCompanyName");
            randomWorker.Work();

            Console.WriteLine("Удаление рабочего из фирмы:");
            company -= new Worker(10, "WorkerName", "Рабочий", 12, "CompanyName");


            Console.WriteLine("РЕЗУЛЬТАТ ВЫПОЛНЕНИЯ ВСЕХ МЕТОДОВ БРИГАДИРА");
            Console.WriteLine("Добавление рабочего в фирму:");
            company += new Foreman(30, "ForemanName", "Бригадир", 15, "CompanyName");

            Console.WriteLine("Присутствует ли бригадир в компании:");
            _foreman.IsStaffOnCompany(30, "Name");

            Console.WriteLine("Получение всех сотрудников типа Foreman:");
            _company.Show("Бригадир");

            Console.WriteLine("Получение количества сотрудников типа Foreman:");
            _company.Counting("Бригадир");

            Console.WriteLine("Результаты выполнения методов класса Foreman:");
            var randomForeman = new Foreman(40, "RandomForemanName", "Бригадир", 17, "RandomCompanyName");
            randomForeman.Work();
            randomForeman.Checking();

            Console.WriteLine("Удаление бригадира из фирмы:");
            company -= new Foreman(40, "ForemanName", "Бригадир", 15, "CompanyName");


            Console.WriteLine("РЕЗУЛЬТАТ ВЫПОЛНЕНИЯ ВСЕХ МЕТОДОВ МЕНЕДЖЕРА");
            Console.WriteLine("Добавление рабочего в фирму:");
            company += new Manager(50, "ManagerName", "Менеджер", 20, "CompanyName");

            Console.WriteLine("Присутствует ли менеджер в компании:");
            _manager.IsStaffOnCompany(50, "Name");

            Console.WriteLine("Получение всех сотрудников типа Manager:");
            _company.Show("Менеджер");

            Console.WriteLine("Получение количества сотрудников типа Manager:");
            _company.Counting("Менеджер");

            Console.WriteLine("Результаты выполнения методов класса Manager:");
            var randomManager = new Manager(60, "RandomManagerName", "Менеджер", 20, "RandomCompanyName");
            randomManager.Work();
            randomManager.GiveAnAssignment();

            Console.WriteLine("Удаление менеджера из фирмы:");
            company -= new Manager(50, "ManagerName", "Менеджер", 20, "CompanyName");

            Console.WriteLine("Список всех сотрудников фирмы:");
            _company.ShowAll("Name");
        }
    }
}
