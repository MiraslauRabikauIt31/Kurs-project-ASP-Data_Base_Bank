using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.EmployeesViewModel
{
    public class EmployeesSortViewModel
    {
        public SortState EmployeeIDSort { get; private set; }
        public SortState NameEmplSort { get; private set; }
        public SortState SurnameEmplSort { get; private set; }
        public SortState MiddlenameEmplSort { get; private set; }
        public SortState PatronymicSort { get; private set; }
        public SortState DateofBirthSort { get; private set; }
        public SortState Current { get; private set; }

        public EmployeesSortViewModel(SortState sortOrder)
        {
            EmployeeIDSort = sortOrder == SortState.EmployeeIDAsc ? SortState.EmployeeIDDesc : SortState.EmployeeIDAsc;
            NameEmplSort = sortOrder == SortState.NameOfEmplAsc ? SortState.NameOfEmplDesc : SortState.NameOfEmplAsc;
            SurnameEmplSort = sortOrder == SortState.SurnameOfEmplAsc ? SortState.SurnameOfEmplDesc : SortState.SurnameOfEmplAsc;
            MiddlenameEmplSort = sortOrder == SortState.MiddlenameOfEmplAsc ? SortState.MiddlenameOfEmplDesc : SortState.MiddlenameOfEmplAsc;
            PatronymicSort = sortOrder == SortState.PatronymicAsc ? SortState.PatronymicDesc : SortState.PatronymicAsc;
            DateofBirthSort = sortOrder == SortState.DateofBirthAsc ? SortState.DateofBirthDesc : SortState.DateofBirthAsc;
            Current = sortOrder;
        }
    }
}
