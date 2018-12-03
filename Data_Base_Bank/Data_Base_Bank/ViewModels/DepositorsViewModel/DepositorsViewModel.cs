using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.DepositorsViewModel
{
    public class DepositorsViewModel
    {
        public IEnumerable<Depositor> Depositors { get; set; }
        public Depositor Depositor { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public DepositorsSortViewModel SortViewModel { get; set; }
        public DepositorsFilterViewModel FilterViewModel { get; set; }
    }
}
