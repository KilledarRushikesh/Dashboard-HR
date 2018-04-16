using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class PersonalInformation:JoiningInformation
    {
        [Display(Name = "BLOOD GROUP")]
        public string BloodGroup { get; set; }
        [Display(Name = "Local Address")]
        public string LocalAddress { get; set; }
        [Display(Name = "Permanant Address")]
        public string PermanantAddress { get; set; }
        public string PAN { get; set; }
        public string PassportNumber { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }
        [Display(Name = "Spouse Name")]
        public string SpouseName { get; set; }
        [Display(Name = "Spouse DOB")]
        public string SpouseDOB { get; set; }
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }
        [Display(Name = "Child DOB")]
        public string ChildDOB { get; set; }
        [Display(Name = "Wedding Anniversary")]
        public string WeddingAnniversary { get; set; }
    }
}