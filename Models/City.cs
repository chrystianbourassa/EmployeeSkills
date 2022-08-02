using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class City
    {
        [Key]

        [Display(Name = "ID")]
        public int CityID { get; set; }

        [Display(Name = "Ville")]
        public string Name { get; set; }



    }
}
