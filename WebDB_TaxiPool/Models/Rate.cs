using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Rate
    {
        [Display(Name = "Код тарифа")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Стоимость")]
        public long Cost { get; set; }
        public IList<Call> Call { get; set; }
    }
}
