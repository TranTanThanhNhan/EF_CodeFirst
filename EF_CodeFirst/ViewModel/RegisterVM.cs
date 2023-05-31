﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Username can't be blank")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword can't be blank")]
        [Compare("Password",ErrorMessage = "Password and " +
            "Confirm password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage ="Invaild email")]
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? DateOfBirthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}