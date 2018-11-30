using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels.DepositsViewModel;

namespace Data_Base_Bank.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Currency> Currencies { get; set; }
        public IEnumerable<Depositor> Depositors { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Typedeposit> Typedeposits { get; set; }
        public IEnumerable<Deposit> Deposits { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public DepositViewModel DepositViewModel { get; set; }
    }
}
