﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Level
    {
        [Key]

        [Display(Name = "ID Niveau")]
        public int LevelID { get; set; }
        [Display(Name = "Niveau")]
        public string Description { get; set; }
    }
}
