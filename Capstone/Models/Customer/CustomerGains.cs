using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerGains
    {
        [Key]
        public int CustomerId;
        [Display(Name = "Your Earnings from your Primary Job: $")]
        public double CustomerEarnings { get; set; }
        [Display(Name = "Your Earnings from your Secondary Job: $")]
        public double CustomerEarnings2 { get; set; }
        [Display(Name = "Your Earnings from Other Jobs: $")]
        public double CustomerEarnings3 { get; set; }
        [Display(Name = "Other Monetary Gains Not from Work: $")]
        public double CustomerOtherGains { get; set; }
    }
}