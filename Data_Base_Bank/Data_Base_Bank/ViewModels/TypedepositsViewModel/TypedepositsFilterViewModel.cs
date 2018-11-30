using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.ViewModels.TypedepositsViewModel
{
    public class TypedepositsFilterViewModel
    {
        public string SelectedType { get; private set; }
        public string Selectdepositamount { get; private set; }

        public TypedepositsFilterViewModel(string type, string depositamount)
        {
            SelectedType = type;
            Selectdepositamount = depositamount;
        }
    }
}
