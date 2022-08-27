﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(5, ErrorMessage = "Must be at least 5-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be at least 5-30 characters")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Must be at least30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
