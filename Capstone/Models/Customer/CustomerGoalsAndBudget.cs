using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerGoalsAndBudget
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Savings for the Future: $")]
        public double Savings { get; set; }
        [Display(Name = "Savings for Upcoming Expenses: $")]
        public double SavingForExpenses { get; set; }
        [Display(Name = "Food/Drinks: $")]
        public double BudgetFoodDrinks { get; set; }
        [Display(Name = "Rent/Home Utilities: $")]
        public double BudgetRentHomeUtilities { get; set; }
        [Display(Name = "Car/Transportation Expenses: $")]
        public double BudgetCarTransportationExpenses { get; set; }
        [Display(Name = "Clothes/Shoes: $")]
        public double BudgetClothesShoes { get; set; }
        [Display(Name = "Health/Beauty: $")]
        public double BudgetHealthBeauty { get; set; }
        [Display(Name = "Charity/Support of NonDependents: $")]
        public double BudgetGoodwill { get; set; }
        [Display(Name = "Entertainment/Recreation: $")]
        public double BudgetEntertainmentRecreation { get; set; }
    }
}