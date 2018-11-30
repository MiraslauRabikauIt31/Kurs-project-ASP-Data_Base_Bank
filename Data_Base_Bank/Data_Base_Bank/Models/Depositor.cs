using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.Models
{
    public class Depositor
    {
        [Key]
        [Display(Name ="Код Вкладчика")]
        public int DepositorID { get; set; }
        [Display(Name ="Имя Вкладчика")]
        public string NameDep { get; set; }
        [Display(Name ="Фамилия Вкладчика")]
        public string SurnameDep { get; set; }
        [Display(Name ="Отчество Вкладчика")]
        public string MiddlenameDep { get; set; }
        [Display(Name ="Адрес")]
        public string Addres { get; set; }
        [Display(Name ="Телефон")]
        public string Phone { get; set; }
        [Display(Name ="Паспортные данные")]
        public string Passportdata { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }

        public Depositor()
        {
            Deposits = new List<Deposit>();
        }
    }
}
