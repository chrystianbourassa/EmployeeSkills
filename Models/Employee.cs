using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Models
{
    public class Employee
    {
        [Key]

        [Display(Name = "ID Employé")]
        public int EmployeeID { get; set; }

        [Display(Name = "Nom Complet")]
        public string FullName { get; set; } = null!;
        [Display(Name = "Date de naissance")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Date d'embauche")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Display(Name = "Code Postal")]
        public string PostalCode { get; set; }
        [Display(Name = "Pays")]
        public string Country { get; set; }
        [Display(Name = "Téléphone")]
        public string HomePhone { get; set; }
        [Display(Name = "Note")]
        public string Notes { get; set; }

        [Display(Name = "Photo de profil")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Résumé")]
        public string ResumePath { get; set; }
        //------------------------------------------------
        // Maybe sub categories can have one category
        //------------------------------------------------
        public City City { get; set; }
        // to Employee_Skills
        public List<Employee_Skill> Employees_Skills { get; set; }

    }
}
