﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(111,ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength =6)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Harus diisi sama dengan password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name="Role Name")]
        public string RoleName { get; set; }
    }
}
