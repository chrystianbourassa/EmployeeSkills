using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Skill
    {

        [Key]

        [Display(Name = "Compétence")]
        public int SkillID { get; set; }
        [Display(Name = "Nom de Compétence")]
        public string Title { get; set; }

        //------------------------------------------------
        // 1 to 1 relationship
        //------------------------------------------------

        // to Category table
 
        public Category Category { get; set; }

        public SubCategory SubCategory { get; set; }


        //------------------------------------------------
        // Many to Many relationship
        //------------------------------------------------

        // to Employee_Skills
        public List<Employee_Skill> Employees_Skills { get; set; }



    }
}
