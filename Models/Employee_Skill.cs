using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Employee_Skill
    {
        [Key]
        public int Employee_SkillID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int SkillID { get; set; }
        public Skill Skill { get; set; }

        public int LevelID { get; set; }
        public Level Level { get; set; }

        public int InterestID { get; set; }
        public Interest Interest{ get; set; }





    }
}
