using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "enter your First name")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "enter your last name")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "enter your mail")]
        [Display(Name = "mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "password and confirmation must be same!!!")]
        public string ConfirmPassword { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "enter your phonenumber")]
        [Display(Name = "number")]
        public string MobileNumber { get; set; }

        public DateTime Birthday { get; set; }
    }
}