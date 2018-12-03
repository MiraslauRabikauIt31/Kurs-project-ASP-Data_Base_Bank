using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.Models
{
    public class Employee
    {
        [Key]
        [Display(Name ="Код сотрудника")]
        public int EmployeeID { get; set; }
        [Display(Name ="Имя сотрудника")]
        public string NameEmpl { get; set; }
        [Display(Name ="Фаимлия сотрудника")]
        public string SurnameEmpl { get; set; }
        [Display(Name ="Отчество сотрудника")]
        public string MiddlenameEmpl { get; set; }
        [Display(Name ="Должность")]
        public string Patronymic { get; set; }
        [Display(Name ="Дата рождения")]
        [DataType(DataType.Date)]
        public System.DateTime DateofBirth { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public Employee()
        {
            Deposits = new List<Deposit>();
        }
    }
}
