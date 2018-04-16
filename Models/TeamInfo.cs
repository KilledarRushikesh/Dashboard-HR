using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class TeamInfo
    {
        public int TeamsDetailsId { get; set; }
        public string TeamName { get; set; }
        
        public string TeamLeader { get; set; }

        public string ProjectLead { get; set; }

        List<TeamMembers> teamMembers { get; set; }
    }
}