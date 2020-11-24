using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Call
    {
        public long ID { get; set; }
        [Display(Name = "Дата и время")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        [Display(Name = "Откуда")]
        public string From { get; set; }
        [Display(Name = "Куда")]
        public string To { get; set; }
        [Display(Name = "Код тарифа")]
        public long? RateID { get; set; }
        public Rate Rate { get; set; }
        [Display(Name = "Код услуги")]
        public long? ServiceID { get; set; }
        public Service Service { get; set; }
        [Display(Name = "Код автомобиля ")]
        public long? AutoID { get; set; }
        public Auto Auto { get; set; }
        [Display(Name = "Код сотрудника-оператора ")]
        public long? OperID { get; set; }
        public Staff Oper { get; set; }
    }
}
