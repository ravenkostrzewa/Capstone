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
        public string Age { get; set; }    //math   (calculate from birthdate)
        [Display(Name = "Earned Income: $")]
        public double TotalCustomerEarnings { get; set; }   //math   (add individual jobs together, to each other, divide by # of customers)
        [Display(Name = "Monetary Gains Not from Work: $")]
        public double NonIncomeGains { get; set; }   //math   (add entries, divide by # of customers)
        [Display(Name = "Debt: $")]
        public int Debt { get; set; }
        [Display(Name = "Total Saved")]
        public double TotalSaved { get; set; }      //math    (add entries, divide by # of customers)
        [Display(Name = "Total Spent")]
        public double TotalSpent { get; set; }     //math    (add individual spending together, to each other, divide by # of customers)
    }
}