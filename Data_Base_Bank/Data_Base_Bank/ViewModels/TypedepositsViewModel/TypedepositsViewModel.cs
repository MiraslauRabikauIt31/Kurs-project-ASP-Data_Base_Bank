using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.TypedepositsViewModel
{
    public class TypedepositsViewModel
    {
        public IEnumerable<Typedeposit> Typedeposits { get; set; }
        public Typedeposit Typedeposit { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public TypedepositsSortViewModel SortViewModel { get; set; }
        public TypedepositsFilterViewModel FilterViewModel { get; set; }
    }
}
