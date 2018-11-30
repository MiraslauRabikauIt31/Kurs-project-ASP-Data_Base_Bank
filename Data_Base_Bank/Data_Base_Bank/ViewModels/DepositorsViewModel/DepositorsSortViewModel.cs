using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.DepositorsViewModel
{
    public class DepositorsSortViewModel
    {
        public SortState DepositorIDSort { get; private set; }
        public SortState NameDepSort { get; private set; }
        public SortState SurnameDepSort { get; private set; }
        public SortState MiddlenameDepSort { get; private set; }
        public SortState AddresSort { get; private set; }
        public SortState PhoneSort { get; private set; }
        public SortState Passportdata { get; private set; }
        public SortState Current { get; private set; }

        public DepositorsSortViewModel(SortState sortOrder)
        {
            DepositorIDSort = sortOrder == SortState.DepositorIDAsc ? SortState.DepositorIDDesc : SortState.DepositorIDAsc;
            NameDepSort = sortOrder == SortState.NameOfDepAsc ? SortState.NameOfDepDesc : SortState.NameOfDepAsc;
            SurnameDepSort = sortOrder == SortState.SurnameOfDepAsc ? SortState.SurnameOfDepDesc : SortState.SurnameOfDepAsc;
            MiddlenameDepSort = sortOrder == SortState.MiddlenameOfDepAsc ? SortState.MiddlenameOfDepDesc : SortState.MiddlenameOfDepAsc;
            AddresSort = sortOrder == SortState.AddresAsc ? SortState.AddresDesc : SortState.AddresAsc;
            PhoneSort = sortOrder == SortState.PhoneAsc ? SortState.PhoneDesc : SortState.PhoneAsc;
            Passportdata = sortOrder == SortState.PassportdataAsc ? SortState.PassportdataDesc : SortState.PassportdataAsc;
            Current = sortOrder;
        }
    }
}
