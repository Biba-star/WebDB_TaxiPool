using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Call
    {
        [Display(Name = "Дата и время")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        [Display(Name = "Откуда")]
        public string From { get; set; }
        [Display(Name = "Куда")]
        public string To { get; set; }
    }
}
