using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }
        public ApplicationUser(string? fullName, string? dNI)
        {
            FullName = fullName;
            DNI = dNI;
        }

        public string? FullName { get; set; }
        public string? DNI { get; set; }


    }
}
