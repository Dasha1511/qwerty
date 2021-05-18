using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class raspisanie
    {
        [Display(Name = "Код расписание")]
        public long ID { get; set; }


        [Display(Name = "Дата")]
        public DateTime Data { get; set; }


        [Display(Name = "День недели")]
        public string Den_nedeli { get; set; }

        [Display(Name = "Время начала")]
        public DateTime Vrema_nachala { get; set; }


        [Display(Name = "Время окончание")]
        public DateTime Vrema_okonchania { get; set; }


        [Display(Name = "Код класса")]
        public long? classID { get; set; }

        [Display(Name = "Класс")]
        public DbSet<Class> Class { get; set; }



        [Display(Name = "Код предмета")]
        public long? predmetID { get; set; }

        [Display(Name = "Предмет")]
        public DbSet<predmet> predmet { get; set; }
    }
}
