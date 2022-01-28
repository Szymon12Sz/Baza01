using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baza01.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "FullName")]
        public string FullName { get; set; }
    }
}
