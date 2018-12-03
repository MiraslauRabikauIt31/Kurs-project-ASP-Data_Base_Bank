using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.ViewModels.EmployeesViewModel
{
    public class EmployeesFilterViewModel
    {
        public string SelectedName { get; private set; }
        public string SelectedSurname { get; private set; }
        public string SelectedPatronymic { get; private set; }

        public EmployeesFilterViewModel(string name, string surname, string patronymic)
        {
            SelectedName = name;
            SelectedSurname = surname;
            SelectedPatronymic = patronymic;
        }
    }
}
