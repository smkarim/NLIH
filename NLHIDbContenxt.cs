using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;




using NLIH.Models;

namespace NLIH
{
    public class NLHIDbContenxt : DbContext
    {
        public NLHIDbContenxt() : base("NLIHDatabase")
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Patient> Patients { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<User>().Map<Guest>(g => g.Requires("UserId").HasValue("Id"));
            
            modelBuilder.Entity<Guest>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Guest");
            });

            modelBuilder.Entity<Doctor>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Doctor");
            });

            modelBuilder.Entity<Staff>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Staff");
            });

            modelBuilder.Entity<Patient>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Patient");
            });

            modelBuilder.Entity<Nurse>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Nurse");
            });

            modelBuilder.Entity<TechnicalEmployee>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("TechnicalEmployee");
            });

            modelBuilder.Entity<Accounts>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Accounts");
            });

            modelBuilder.Entity<Finance>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Finance");
            });

            modelBuilder.Entity<Admin>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Admin");
            });

            modelBuilder.Entity<Customer>().Map(m =>
            {
                m
                .MapInheritedProperties()
                .ToTable("Customer");
            });

            modelBuilder.Entity<User>().Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }// */

    }
}