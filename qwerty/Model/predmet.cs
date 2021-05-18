using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class predmet
    {
        [Display(Name = "Код предмета")]
        public long ID { get; set; }


        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }


        [Display(Name = "Описание")]
        public string Opisanie { get; set; }


        [Display(Name = "Код сотрудника-учителя")]
        public long? sotrudnikiID { get; set; }

        [Display(Name = "Сотрудник-учитель")]
        public DbSet<sotrudniki> sotrudniki { get; set; }
    }
}
