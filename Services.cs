using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThinkBridge.Models;

namespace ThinkBridge
{
    public class Services
    {
        public DatabaseContext database;
        public List<TeamDetails> AllTeams()
        {
            List<TeamDetails> list = (from teams in database.TeamDetails
                                     select teams).ToList();
            return list;
        }
    }
   
}