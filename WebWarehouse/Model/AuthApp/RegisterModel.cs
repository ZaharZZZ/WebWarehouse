﻿using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model.AuthApp
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Подтверждение введено неверно")]
        public string ConfirmPassword { get; set; }
    }
}
