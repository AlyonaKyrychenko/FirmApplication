using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firm.Data.Repositories;
using Firm.Data.Contracts;

namespace Firm
{
    public static class AutofacConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Staff<Worker>>().As<IStaff<Worker>>();
            builder.RegisterType<Staff<Foreman>>().As<IStaff<Foreman>>();
            builder.RegisterType<Staff<Manager>>().As<IStaff<Manager>>();
            builder.RegisterType<Company>().As<ICompany>();

            return builder.Build();
        }
    }
}
