using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Party.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли вы участие")]
        public bool? WillAttent { get; set; }
    }
}