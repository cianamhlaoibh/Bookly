using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookly.Models
{
    public class AppUser :IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public String Surname { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
