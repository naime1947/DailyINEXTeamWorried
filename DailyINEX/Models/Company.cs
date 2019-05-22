using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DailyINEX.Models
{
    public class Company
    {
        [Display(Name ="Company Name")]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "Company Email")]
        [Required]
        public string CompanyEmail { get; set; }

        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage ="Minimum password lenth is 6 charecter")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password can confirm password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name ="Country")]
        [Required]
        public int CountryId { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}