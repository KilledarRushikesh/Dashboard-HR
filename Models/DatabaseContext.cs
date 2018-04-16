using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TeamMembers> TeamMembers { get; set; }

        public DbSet<TeamDetails> TeamDetails { get; set; }
    }
}