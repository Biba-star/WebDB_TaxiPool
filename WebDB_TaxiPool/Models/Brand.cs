using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Brand
    {
        [Display(Name = "Код марки")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Технические характеристики")]
        public string Specifications { get; set; }
        [Display(Name = "Стоимость")]
        public long Cost { get; set; }
        [Display(Name = "Специфика")]
        public string Specificity { get; set; }
        public IList<Auto> Auto { get; set; }
    }
}
