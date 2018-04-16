using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ThinkBridge.Models;

namespace ThinkBridge.Models
{
    public class TeamMembers
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        public int TeamMemberID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Team")]
        public string TeamName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }
        
        [Display(Name = "Employee Status")]
        public string EmployeeStatus { get; set; }
        [Required]
        [Display(Name = "Medical Insurance By Thinkbridge")]
        public Boolean MedicalInsuaranceByThinkbridge { get; set; }
        [Required]
        [Display(Name = "PF UAN Number")]
        public string PFNumber { get; set; }
        

        [Required]
        public string Designation { get; set; }


        [Required]
        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? JoiningDate { get; set; }
        [Required]
        [Display(Name = "Previous Experience")]
        public string PreviousExperience { get; set; }
        [Required]
        [Display(Name = "Educational Qualification")]
        public string Education { get; set; }
        [Required]
        [Display(Name = "Joining Gross CTC")]
        public string CTC { get; set; }
        [Required]
        [Display(Name = "Earlier Salary")]
        public string EarlierSalary { get; set; }
        [Required]
        [Display(Name = "% Hike")]
        public string Hike { get; set; }
        [Required]
        [Display(Name = "Current Experience")]
        public string CurrentExperience { get; set; }
        [Required]
        [Display(Name = "Company Asset Details")]
        public string CompanyAssetDetails { get; set; }
        [Required]
        [Display(Name= "Father's/ Husband’s Name")]
        public string FatherOrHusbandName { get; set; }
        [Required]
        [Display(Name = "Performance Review Month")]
        public string SalaryReviewMonth { get; set; }
        [Display(Name = "Trainee Review")]
        public string TraineeReviewMonth { get; set; }
        [Display(Name = "New Joinee Probation Ending review")]
        public string JoineeProbationReview { get; set; }

        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }
        [Required]
        [Display(Name="Gender")]
        public string Gender { get; set; }
        [Display(Name = "Local Address")]
        public string LocalAddress { get; set; }
        [Display(Name = "Permanant Address")]
        public string PermanantAddress { get; set; }
        public string PAN { get; set; }
        [Display(Name="Passport No.")]
        public string PassportNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Passport Expiry Date")]
        public DateTime? PassportExpiry { get; set; }
        [Display(Name = "Aadhar No.")]
        public string AadharNumber { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DOB { get; set; }
        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }
        [Display(Name ="Bank Name")]
        public string BankName { get; set; }
        [Display(Name ="Bank Account No.")]
        public string AccountNumber { get; set; }
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }


        [Display(Name = "Spouse Name")]
        public string SpouseName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Spouse DOB")]
        public string SpouseDOB { get; set; }
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Child DOB")]
        public string ChildDOB { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Wedding Anniversary Date")]
        public DateTime? WeddingAnniversary { get; set; }

        [Display(Name = "Termination Date")]
        public string TerminationDate{get;set;}
        [Display(Name = "Termination Feedback")]
        public string TerminationFeedback { get; set; }
        [Display(Name = "Termination Reason")]
        public string TerminationReason { get; set; }
        [Display(Name="Medical Insurance Deletion")]
        public Boolean InsuranceDeletion { get; set; }

        public TeamDetails TeamDetails { get; set; }
    }
}