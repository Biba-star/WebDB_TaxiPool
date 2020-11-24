using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Auto
    {
        [Display(Name = "Код автомобиля")]
        public long ID { get; set; }
        [Display(Name = "Код марки")]
        public long? BrandID { get; set; }
        public Brand Brand { get; set; }
        [Display(Name = "Регистрационный номер")]
        public string RegNum { get; set; }
        [Display(Name = "Номер кузова")]
        public string NumberCarBody { get; set; }
        [Display(Name = "Номер двигателя")]
        public string EngineNumber { get; set; }
        [Display(Name = "Год выпуска")]
        public long YearOfIssue { get; set; }
        [Display(Name = "пробег")]
        public long Mileage { get; set; }
        [Display(Name = "Код сотрудника-шофёра")]
        public long? DriverID { get; set; }
        [Display(Name = "сотрудник-шофёр")]
        public Staff Driver { get; set; }
        [Display(Name = "Дата последнего ТО")]
        public DateTime DateLastTI { get; set; }
        [Display(Name = "Код сотрудника-механика")]
        public long? MechID { get; set; }
        [Display(Name = "сотрудник-механик")]
        public Staff Mech { get; set; }
        [Display(Name = "Специальные метки")]
        public string SpecMark { get; set; }
    }
}
