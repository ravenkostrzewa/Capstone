using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerProfile
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "City of Residence:")]
        public string CustomerCity { get; set; }
        [Display(Name = "State of Residence:")]
        public CustomerStates CustomerState { get; set; }
        public enum CustomerStates
        {
            Alabama,
            Alaska,
            Arizona,
            Arkansas,
            California,
            Colorado,
            Connecticut,
            Delaware,
            Florida,
            Georgia,
            Hawaii,
            Idaho,
            Illinois,
            Indiana,
            Iowa,
            Kansas,
            Kentucky,
            Louisiana,
            Maine,
            Maryland,
            Massachusetts,
            Michigan,
            Minnesota,
            Mississippi,
            Missouri,
            Montana,
            Nebraska,
            Nevada,
            New_Hampshire,
            New_Jersey,
            New_Mexico,
            New_York,
            North_Carolina,
            North_Dakota,
            Ohio,
            Oklahoma,
            Oregon,
            Pennsylvania,
            Rhode_Island,
            South_Carolina,
            South_Dakota,
            Tennessee,
            Texas,
            Utah,
            Vermont,
            Virginia,
            Washington,
            West_Virginia,
            Wisconsin,
            Wyoming
        }
        [Display(Name = "Gender")]
        public Gender CustomerGender { get; set; }
        public enum Gender
        {
            Female,
            Male
        }
        [Display(Name = "Job:")]
        public string CustomerJob { get; set; }
        [Display(Name = "Current Occupational Field:")]
        public FieldOfWork CustomerFieldOfWork { get; set; }
        public enum FieldOfWork
        {
            Architecture,
            Art,
            Athletics,
            Business,
            Communication,
            Computer_Science,
            Construction,
            Education,
            Environmental,
            Engineering,
            Farming_Fishing,
            Fashion,
            Food_Services,
            Health_Pharmaceutical,
            Hospitality,
            Human_Resources,
            Law_Enforcement,
            Management,
            Marketing,
            Media,
            Military,
            Office_Administration,
            Production,
            Professional_Services,
            Psychology,
            Repair_Installation,
            Sales,
            Science,
            Transportation,
            Other
        }
        [Display(Name = "Current Job Title:")]
        public string CustomerJobTitle { get; set; }
        [Display(Name = "What is your expected annual income from this position: $_____")]
        public double CustomerExpectedAnnualIncome { get; set; }
        [Display(Name = "Check the box if you have a second job.")]
        public bool SecondaryJob { get; set; }
        [Display(Name = "What is your secondary job?")] //only show if the above box is checked
        public string SecondJob { get; set; }
        [Display(Name = "Check the box if you have more than two jobs.")] //only show if above box is checked
        public bool AdditionalJobs { get; set; }
        [Display(Name = "What are your other jobs?")] //only show if above box is checked
        public string OtherJobs { get; set; }
        [Display(Name = "What do you expect to earn from jobs other than your primary job? $_____")] //only show if SecondaryJob == true
        public double AdditionalEarnings1 { get; set; }
        [Display(Name = "Check the box if you expect to bring in money by means other than working a job.")]
        public bool OtherMeansOfIncome1 { get; set; }
        //if above box is checked
        [Display(Name = "How? Eg. flipping houses, babsitting, collecting rent, receiving alimony check, et cetera")]
        public string SideGig1 { get; set; }
        [Display(Name = "How much do you expect this to bring in this year? $_____")] //if above box is checked
        public double AdditionalRevenue1 { get; set; }
        //if additionalrevenue1 == true
        [Display(Name = "Do you have other additional means of income?")]
        public bool OtherMeansOfIncome2 { get; set; }
        //if above box is checked
        [Display(Name = "How? List all other additional means of income. Eg. flipping houses, babsitting, collecting rent, receiving alimony check, et cetera")]
        public string SideGig2 { get; set; }
        [Display(Name = "How much do you expect this/these to bring in this year? $____")] //if othermeansofincome == true
        public double AdditionalRevenue2 { get; set; }
        [Display(Name = "How many dependents do you have?")]
        public int CustomerDependents { get; set; }
        [Display(Name = "Do you have any debt?")]
        public bool CustomerDebt { get; set; }
        //if above box is checked
        [Display(Name = "How much money do you owe?")]
        public double TotalDebt { get; set; }
    }
}