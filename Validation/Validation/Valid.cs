using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation
{
    public class Valid
    {
        [Required(ErrorMessage ="Поле не заполнено!")]
        [RegularExpression(@"\d+", ErrorMessage = "Надо вводить только числовые значения!")]
        public double t1 { get; set; }
        [Required(ErrorMessage = "Поле не заполнено!")]
        [RegularExpression(@"^[1-9]+[0-9]*$", ErrorMessage = "Значение должно быть больше 0")]
        public double t2 { get; set; }
    }
}