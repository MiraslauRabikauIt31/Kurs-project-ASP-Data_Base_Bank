using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Base_Bank.Models
{
    public class Typedeposit
    {
        [Key]
        [Display(Name ="Код типа вклада")]
        public int TypedepositID { get; set; }
        [Display(Name ="Имя типа")]
        public string NameType { get; set; }
        [Display(Name ="Минимальный срок вклада")]
        [DataType(DataType.Date)]
        public System.DateTime Minimumtermofdeposit { get; set; }
        [Display(Name ="Минимальная сумма вклада")]
        public decimal Minimumdepositamount { get; set; }
        [Display(Name ="Процентная ставка")]
        public decimal Interestrate { get; set; }
        [Display(Name ="Дополнительные условия")]
        public string Additionalconditions { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }

        public Typedeposit()
        {
            Deposits = new List<Deposit>();
        }
    }
}
