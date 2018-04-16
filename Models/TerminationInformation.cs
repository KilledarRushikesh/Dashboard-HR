using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class TerminationInformation:TeamMembers
    {
        [Display(Name = "Termination Date")]
        public string TerminationDate { get; set; }
        [Display(Name = "Termination Feedback")]
        public string TerminationFeedback { get; set; }
        [Display(Name = "Termination Reason")]
        public string TerminationReason { get; set; }
    }
}