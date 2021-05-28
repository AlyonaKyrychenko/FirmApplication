using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Data.Contracts
{
    public interface ICompany
    {
        void Show(string position);
        void ShowAll(string companyName);
        int Counting(string position);
    }
}
