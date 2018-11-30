using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.CurrenciesViewModel
{
    public class CurrenciesSortViewModel
    {
        public SortState CurrencyIDSort { get; private set; }
        public SortState NameCurrencySort { get; private set; }
        public SortState ExchangerateSort { get; private set; }
        public SortState DateSort { get; private set; }
        public SortState Current { get; private set; }

        public CurrenciesSortViewModel(SortState sortOrder)
        {
            CurrencyIDSort = sortOrder == SortState.CurrencyIDAsc ? SortState.CurrencyIDDesc : SortState.CurrencyIDAsc;
            NameCurrencySort = sortOrder == SortState.NameOfCurrencyAsc ? SortState.NameOfCurrencyDesc : SortState.NameOfCurrencyAsc;
            ExchangerateSort = sortOrder == SortState.ExchangerateOfCurrencyAsc ? SortState.ExchangerateOfCurrencyDesc : SortState.ExchangerateOfCurrencyAsc;
            DateSort = sortOrder == SortState.DateOfCurrencyAsc ? SortState.DateOfCurrencyDesc : SortState.DateOfCurrencyAsc;
            Current = sortOrder;
        }
    }
}
