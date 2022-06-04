using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Account
    {

        [Key]

        [Display( Name = "ID Usager")]
        public int UserID { get; set; }
        
        [Display(Name = "Courriel")]
        public string Email { get; set; }
        
        [Display(Name = "Nom Usager")]
        public string Username { get; set; }

        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
    }
}
