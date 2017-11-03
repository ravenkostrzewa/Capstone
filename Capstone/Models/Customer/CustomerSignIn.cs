using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerSignIn
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Email Address:")]
        public string CustomerEmail { get; set; }
        [Display(Name = "Password")]
        public string CustomerPassword { get; set; }
        [Display(Name = "Sign In as an Administrator")]
        public bool AdministratorSignIn { get; set; }
    }
}