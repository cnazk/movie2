using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Xunit.Sdk;

namespace Cinema.Models.Db
{
    public class User: IdentityUser
    {
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        
        
        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public DateTime SignupDate { get; set; }

    }
}
