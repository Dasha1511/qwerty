using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class sotrudniki
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Возраст")]
        public string Old { get; set; }

        [Display(Name = "Пол")]
        public string Pol { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Телефон")]
        public string Pasport { get; set; }

        [Display(Name = "Паспортные данные")]
        public string Telephone { get; set; }

        [Display(Name = "Код должности")]
        public long? DolznostID { get; set; }

        [Display(Name = "Должность")]
        public DbSet<Dolznost> Dolznost { get; set; }
    }
}
