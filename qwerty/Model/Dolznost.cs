using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school.models
{
    public class Dolznost
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }

        [Display(Name = "Наименование должности")]
        public string Naimenovanie_dolznosti { get; set; }

        [Display(Name = "Оклад")]
        public string Oklad { get; set; }


        [Display(Name = "Обязанности")]
        public string Obazannosty { get; set; }


        [Display(Name = "Требования")]
        public string Trebovania { get; set; }

        public static implicit operator Dolznost(List<Dolznost> v)
        {
            throw new NotImplementedException();
        }
    }
}
