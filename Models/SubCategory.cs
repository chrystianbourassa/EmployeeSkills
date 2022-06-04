using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class SubCategory
    {
        [Key]

        [Display(Name = "ID Sous Catégorie")]
        public int SubCategoryID { get; set; }
        [Display(Name = "Sous Catégorie")]
        public string Description { get; set; }

        //------------------------------------------------
        // Maybe sub categories can have one category
        //------------------------------------------------
        public Category Category { get; set; }


    }
}
