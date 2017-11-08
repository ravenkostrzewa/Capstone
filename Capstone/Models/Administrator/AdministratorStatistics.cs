using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class AdministratorStatistics
    { 
        [Key]
        public int Id { get; set; }
        [Display(Name = "Age:")]
        public string Age { get; set; }   
        [Display(Name = "Earned Income: $")]
        public double TotalCustomerEarnings { get; set; } 
        [Display(Name = "Monetary Gains Not from Work: $")]
        public double NonIncomeGains { get; set; }  
        [Display(Name = "Debt: $")]
        public int Debt { get; set; }
        [Display(Name = "Total Saved")]
        public double TotalSaved { get; set; }    
        [Display(Name = "Total Spent")]
        public double TotalSpent { get; set; }     
    }
}