using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EcommerceWebApp.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser():base()
        {
            
        }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ProfilePhoto { get; set; }

    }
}
