using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.CurrenciesViewModel
{
    public class CurrenciesViewModel
    {
        public IEnumerable<Currency> Currencies { get; set; }
        public Currency Currency { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public CurrenciesSortViewModel SortViewModel { get; set; }
        public CurrenciesFilterViewModel FilterViewModel { get; set; }
    }
}
