using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.TypedepositsViewModel
{
    public class TypedepositsSortViewModel
    {
       public SortState TypedepositIDSort { get; private set; }
       public SortState NameTypeSort { get; private set; }
       public SortState MinimumtermofdepositSort { get; private set; }
       public SortState MinimumdepositamountSort { get; private set; }
       public SortState InterestrateSort { get; private set; }
       public SortState AdditionalconditionsSort { get; private set; }
       public SortState Current { get; private set; }

       public TypedepositsSortViewModel(SortState sortOrder)
       {
            TypedepositIDSort = sortOrder == SortState.TypedepositIDAsc ? SortState.TypedepositIDDesc : SortState.TypedepositIDAsc;
            NameTypeSort = sortOrder == SortState.NameOfTypeAsc ? SortState.NameOfTypeDesc : SortState.NameOfTypeAsc;
            MinimumtermofdepositSort = sortOrder == SortState.MinimumTermOfdepositAsc ? SortState.MinimumTermOfdepositDesc : SortState.MinimumTermOfdepositAsc;
            MinimumdepositamountSort = sortOrder == SortState.MinimumDepositAmountAsc ? SortState.MinimumDepositAmountDesc : SortState.MinimumDepositAmountAsc;
            InterestrateSort = sortOrder == SortState.InterestrateAsc ? SortState.InterestrateDesc : SortState.InterestrateAsc;
            AdditionalconditionsSort = sortOrder == SortState.AdditionalconditionsAsc ? SortState.AdditionalconditionsDesc : SortState.AdditionalconditionsAsc;
            Current = sortOrder;
       }
    }
}
