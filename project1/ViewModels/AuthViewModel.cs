using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project1.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
       
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "UserName")]

        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "ContactNo.")]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Education")]
        public string Education { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }


    }
}