using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class TeamDetails
    {
        [Key]
        public int TeamsDetailsId { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string TeamName { get; set; }
        [Display(Name ="Leader")]
        public string TeamLeader { get; set; }

        public string ProjectLead { get; set; }

        public ICollection<TeamMembers> TeamMember { get; set; }
    }
}