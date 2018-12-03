using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.ViewModels.CurrenciesViewModel
{
    public class CurrenciesFilterViewModel
    {
        public string SelectedType { get; private set; }
        public string Selectedexchangerate { get; private set; }

        public CurrenciesFilterViewModel(string type, string exchangerate)
        {
            SelectedType = type;
            Selectedexchangerate = exchangerate;
        }
    }
}
