using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class students
    {
        [Display(Name = "Код ученика")]
        public long ID { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Дата рождения")]
        public DateTime Data_rozdenia { get; set; }

        [Display(Name = "Пол")]
        public string Pol { get; set; }

        [Display(Name = "Адрес")]
        public string Adres { get; set; }

        [Display(Name = "ФИО отца")]
        public string FIO_ot { get; set; }

        [Display(Name = "ФИО матери")]
        public string FIO_mat { get; set; }

        [Display(Name = "Дополнительная информация")]
        public string Dopolnitelnaya_inf { get; set; }


        [Display(Name = "Код класса")]
        public long? ClassID { get; set; }

        [Display(Name = "Класс")]
        public DbSet<Class> Class { get; set; }
    }
}
