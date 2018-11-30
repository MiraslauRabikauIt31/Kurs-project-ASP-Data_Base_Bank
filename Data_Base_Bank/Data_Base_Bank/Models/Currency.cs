using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.Models
{
    public class Currency
    {
        [Key]
        [Display(Name ="Код валюты")]
        public int CurrencyID { get; set; }
        [Display(Name ="Имя валюты")]
        [Required]
        public string NameCurrency { get; set; }
        [Display(Name ="Обменный курс")]
        [Required(ErrorMessage = "Не правильно введено поле")]
        public decimal Exchangerate { get; set; }
        [Display(Name ="Дата")]
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime date_ { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }

        public Currency()
        {
            Deposits = new List<Deposit>();
        }
    }
}
