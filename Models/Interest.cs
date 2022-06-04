using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Interest
    {
        [Key]

        [Display(Name = "Intéret ID")]
        public int InterestID { get; set; }

        [Display(Name = "Niveau d'intéret")]
        public string Description { get; set; }
    }
}
