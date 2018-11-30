using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.ViewModels.DepositsViewModel
{
    public class DepositViewModel
    {
        public int DespositID { get; set; }

        [Display(Name = "Имя валюты")]
        public string NameCurrency { get; set; }

        [Display(Name = "Имя Вкладчика")]
        public string NameDep { get; set; }

        [Display(Name = "Имя типа")]
        public string NameType { get; set; }

        [Display(Name = "Имя сотрудника")]
        public string NameEmpl { get; set; }

        [Display(Name = "Сумма вклада")]
        public decimal Depositsum { get; set; }

        [Display(Name = "Дата вклада")]
        [DataType(DataType.Date)]
        public System.DateTime Datedeposit { get; set; }

        [Display(Name = "Сумма возврата")]
        public decimal Refundamount { get; set; }

        [Display(Name = "Дата возврата")]
        [DataType(DataType.Date)]
        public System.DateTime Datereturn { get; set; }
    }
}
