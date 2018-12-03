using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.Models
{
    public class Deposit
    {
        [Key]
        [Display(Name ="Код вклада")]
        public int DespositID { get; set; }
        [Display(Name ="Код валюты")]
        public int? CurrencyID { get; set; }
        [Display(Name ="Код вкладчика")]
        public int? DepositorID { get; set; }
        [Display(Name ="Код Типа вклада")]
        public int? TypedepositID { get; set; }
        [Display(Name ="Код Сотрудника")]
        public int? EmployeeID { get; set; }
        [Display(Name ="Сумма вклада")]
        public decimal Depositsum { get; set; }
        [Display(Name ="Дата вклада")]
        [DataType(DataType.Date)]
        public System.DateTime Datedeposit { get; set; }
        [Display(Name ="Сумма возврата")]
        public decimal Refundamount { get; set; }
        [Display(Name ="Дата возврата")]
        [DataType(DataType.Date)]
        public System.DateTime Datereturn { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Depositor Depositor { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Typedeposit Typedeposit { get; set; }
    }
}
