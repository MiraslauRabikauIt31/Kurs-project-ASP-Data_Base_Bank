using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.DepositsViewModel
{
    public class DepositsSortViewModel
    {
        public SortState DespositIDSort { get; private set; }
        public SortState TypeCurrencySort { get; private set; }
        public SortState TypeDepSort { get; private set; }
        public SortState TypeTypedepSort { get; private set; }
        public SortState TypeEmployeeSort { get; private set; }
        public SortState DepositsumSort { get; private set; }
        public SortState DatedepositSort { get; private set; }
        public SortState RefundamountSort { get; private set; }
        public SortState DatereturnSort { get; private set; }
        public SortState Current { get; private set; }

        public DepositsSortViewModel(SortState sortOrder)
        {
            DespositIDSort = sortOrder == SortState.DespositIDAsc ? SortState.DespositIDDesc : SortState.DespositIDAsc;
            TypeCurrencySort = sortOrder == SortState.TypeOfCurrencyAsc ? SortState.TypeOfCurrencyDesc : SortState.TypeOfCurrencyAsc;
            TypeDepSort = sortOrder == SortState.TypeOfDepositorAsc ? SortState.TypeOfDepositorDesc : SortState.TypeOfDepositorAsc;
            TypeTypedepSort = sortOrder == SortState.TypeOfTypedepositAsc ? SortState.TypeOfTypedepositDesc : SortState.TypeOfTypedepositAsc;
            TypeEmployeeSort = sortOrder == SortState.TypeOfEmployeeAsc ? SortState.TypeOfEmployeeDesc : SortState.TypeOfEmployeeAsc;
            DepositsumSort = sortOrder == SortState.DepositsumAsc ? SortState.DepositsumDesc : SortState.DepositsumAsc;
            DatedepositSort = sortOrder == SortState.DatedepositAsc ? SortState.DatedepositDesc : SortState.DatedepositAsc;
            RefundamountSort = sortOrder == SortState.RefundamountAsc ? SortState.RefundamountDesc : SortState.RefundamountAsc;
            DatereturnSort = sortOrder == SortState.DatereturnAsc ? SortState.DatereturnDesc : SortState.DatereturnAsc;
            Current = sortOrder;
        }
    }
}
