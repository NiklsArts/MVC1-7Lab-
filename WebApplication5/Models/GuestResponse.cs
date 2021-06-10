using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication5
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, выберите вариант")]
        public bool? WillAttend { get; set; }

    }
}
