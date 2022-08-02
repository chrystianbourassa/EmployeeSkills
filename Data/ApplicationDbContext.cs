using EmployeeSkill.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSkill.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employee_Skill>().HasKey(sc => new { sc.EmployeeID, sc.SkillID, sc.InterestID });

            modelBuilder.Entity<Employee_Skill>()
                .HasOne<Employee>(sc => sc.Employee)
                .WithMany(s => s.Employees_Skills)
                .HasForeignKey(sc => sc.EmployeeID);


            modelBuilder.Entity<Employee_Skill>()
                .HasOne<Skill>(sc => sc.Skill)
                .WithMany(s => s.Employees_Skills)
                .HasForeignKey(sc => sc.SkillID);

            modelBuilder.Entity<Employee_Skill>()
                .HasOne<Level>(sc => sc.Level)
                .WithMany(s => s.Employees_Skills)
                .HasForeignKey(sc => sc.LevelID);

            modelBuilder.Entity<Employee_Skill>()
                .HasOne<Interest>(sc => sc.Interest)
                .WithMany(s => s.Employees_Skills)
                .HasForeignKey(sc => sc.InterestID);


            //modelBuilder.Entity<SubCategory>()
            //.HasOne<Category>(s => s.Category)
            //.WithMany(g => g.SubCategories)
            //.HasForeignKey(s => s.SubCategoryID);



        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Employee_Skill> Employees_Skills { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
