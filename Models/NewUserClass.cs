using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WEBFORMSAssignment.Models
{
    public class NewUserClass
    {
        [Required(ErrorMessage ="Please Enter Username")]
        [Display(Name ="User Name")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please confirm Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Pwd")]
        public string Repwd { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Select the Gender")]
        [Display(Name = "Gender")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Please Select the Maritalstatus")]
        [Display(Name = "MaritalStatus")]
        public string Maritalstatus { get; set; }

        [Required(ErrorMessage = "Please Enter the Date")]
        [Display(Name = "Joindate")]
        public DateTime Joindate { get; set; }
    }
}