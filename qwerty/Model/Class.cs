using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class Class
    {
        [Display(Name = "Код класса")]
        public long ID { get; set; }


        [Display(Name = "Количество учеников")]
        public string Kolichestvo_uchenikov { get; set; }


        [Display(Name = "Буква")]
        public string Bukva { get; set; }


        [Display(Name = "Год обучения")]
        public DateTime God_obuchenia { get; set; }


        [Display(Name = "Год создания")]
        public DateTime God_sozdania { get; set; }


        [Display(Name = "Код сотрудника-классного руководителя")]
        public long? sotrudnikiID { get; set; }

        [Display(Name = "Сотрудник")]
        public DbSet<sotrudniki> sotrudniki { get; set; }


        [Display(Name = "Код вида")]
        public long? vidID { get; set; }

        [Display(Name = "Вид класса")]
        public DbSet<vid> vid { get; set; }
    }
}
