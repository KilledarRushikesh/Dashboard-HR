using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThinkBridge.Models
{
    public class Signup
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


    }
}