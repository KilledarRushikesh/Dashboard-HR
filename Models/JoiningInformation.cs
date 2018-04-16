using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class JoiningInformation:EmployeeInformation
    {
        [Required]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }
        [Required]
        [Display(Name = "Previous Experience")]
        public string PreviousExperience { get; set; }
        [Required]
        [Display(Name = "Joining Gross CTC")]
        public string CTC { get; set; }
        [Required]
        [Display(Name = "Earlier Salary")]
        public string EarlierSalary { get; set; }
        [Required]
        [Display(Name = "Current Experience")]
        public string CurrentExperience { get; set; }
        [Required]
        [Display(Name = "Company Asset Details")]
        public string CompanyAssetDetails { get; set; }
        [Required]
        [Display(Name = "Salary Review Month")]
        public string SalaryReviewMonth { get; set; }
    }
}