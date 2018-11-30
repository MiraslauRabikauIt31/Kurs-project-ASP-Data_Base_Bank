using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.ViewModels.EmployeesViewModel
{
    public class EmployeesViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public Employee Employee { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public EmployeesSortViewModel SortViewModel { get; set; }
        public EmployeesFilterViewModel FilterViewModel { get; set; }
    }
}
