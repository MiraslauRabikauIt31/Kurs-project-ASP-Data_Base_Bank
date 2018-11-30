using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels.DepositsViewModel;

namespace Data_Base_Bank.ViewModels.DepositsViewModel
{
    public class DepositsViewModel
    {
        public IEnumerable<Deposit> Deposits { get; set; }

        public DepositViewModel DepositViewModel { get; set; }

        public PageViewModel PageViewModel { get; set; }

        public SelectList CurrenciesList { get; set; }

        public SelectList DepositorsList { get; set; }

        public SelectList EmployeesList { get; set; }

        public SelectList TypedepositsList { get; set; }

        public DepositsSortViewModel SortViewModel { get; set; }

        public DepositsFilterViewModel FilterViewModel { get; set; }
    }
}
