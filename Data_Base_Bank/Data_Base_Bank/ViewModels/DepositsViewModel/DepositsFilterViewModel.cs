using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Data_Base_Bank.ViewModels.DepositsViewModel
{
    public class DepositsFilterViewModel
    {
        public SelectList Currencies { get; private set; }
        public SelectList Typesdeposits { get; private set; }
        public int? SelectedCurrency { get; private set; }
        public int? SelectedTypesdeposit { get; private set; }

        public DepositsFilterViewModel(List<Currency> currencies, List<Typedeposit> typedeposits, int? currency, int? typedeposit)
        {
            currencies.Insert(0, new Currency { CurrencyID = 0, NameCurrency = "Все" });
            typedeposits.Insert(0, new Typedeposit { TypedepositID = 0, NameType = "Все" });
            Currencies = new SelectList(currencies, "CurrencyID", "NameCurrency", currency);
            Typesdeposits = new SelectList(typedeposits, "TypedepositID", "NameType", typedeposit);
        }

    }
}
