using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_TaxiPool.Models
{
    public class Staff
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }
        [Display(Name = "Код должности")]
        public long? PositionID { get; set; }
        [Display(Name = "Должность")]
        public Position Position { get; set; }
        public List<Auto> Auto { get; set; }
        public List<Call> Call { get; set; }
    }
}
