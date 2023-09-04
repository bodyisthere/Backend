﻿using System.ComponentModel.DataAnnotations;

namespace PartyRoom.Core.DTOs.User
{
    public class UserRegistrationDTO
    {
        [Required(ErrorMessage = "Поле 'FirstName' обязательно для заполнения.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле 'LastName' обязательно для заполнения.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле 'UserName' обязательно для заполнения.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле 'Email' обязательно для заполнения.")]
        [EmailAddress(ErrorMessage = "Некорректный формат электронной почты.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле 'PhoneNumber' обязательно для заполнения.")]
        [Phone(ErrorMessage = "Некорректный формат номера телефона.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле 'Password' обязательно для заполнения.")]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля должна быть не менее 6 символов.")]
        public string Password { get; set; }
    }
}
