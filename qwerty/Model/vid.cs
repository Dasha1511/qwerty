using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class vid
    {
        [Display(Name = "Код вида")]
        public long ID { get; set; }

        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }

        [Display(Name = "Описание")]
        public string Opisanie { get; set; }
    }
}
