﻿using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    //Kullanıcı kayıt formu için gerekli bilgileri ve doğrulama kurallarını içeren view model
    public class RegistrationViewModel
    {

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email  is required.")]
        [MaxLength(100, ErrorMessage = "Max 100 characters.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max 20 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password  is required.")]
        [StringLength(20,MinimumLength = 5, ErrorMessage = "5-20 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please confirm your password")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }




    }
}
