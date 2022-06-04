using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Category
    {
        [Key]

        [Display(Name = "ID Catégorie")]
        public int CategoryID { get; set; }
        [Display(Name = "Nom de catégorie")]
        public string Description { get; set; }



        public List<SubCategory> SubCategories { get; set; }
    }
}
