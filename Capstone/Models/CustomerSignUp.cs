using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerSignUp
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Name:")]
        public string CustomerName { get; set; }
        [Display(Name = "Birth Date:")]
        public int CustomerBirthDate { get; set; } //dropdown menu for birthdate, then calculate age
        [Display(Name = "Email Address:")]
        public string CustomerEmail { get; set; }
        [Display(Name = "Password:")]
        public string CustomerPassword { get; set; }
    }
}