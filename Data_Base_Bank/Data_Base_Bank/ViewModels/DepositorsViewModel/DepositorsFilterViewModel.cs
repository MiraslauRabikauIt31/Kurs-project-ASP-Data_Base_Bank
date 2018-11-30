using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.DepositorsViewModel
{
    public class DepositorsFilterViewModel
    {
        public string SelectedName { get; private set; }
        public string SelectedSurname { get; private set; }
        public string SelectedPatronymic { get; private set; }

        public DepositorsFilterViewModel(string name, string surname, string patronymic)
        {
            SelectedName = name;
            SelectedSurname = surname;
            SelectedPatronymic = patronymic;
        }
    }
}
