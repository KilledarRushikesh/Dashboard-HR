using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class EmployeeInformation : TeamMembers
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Team")]
        public string TeamName { get; set; }
        [Required]
        [Display(Name = "Email ID")]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = "Employee Status")]
        public string EmployeeStatus { get; set; }
    }
}