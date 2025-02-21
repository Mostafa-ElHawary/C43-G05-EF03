using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample.Context
{
    internal class AppDpContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TPH
            //modelBuilder.Entity<FullTimeEmployees>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployees>().HasBaseType<Employee>();

            //TPC
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            //modelBuilder.Entity<FullTimeEmployees>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployees>().ToTable("PartTimeEmployees");

            //TPCC

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InheritanceExampleEF03;Trusted_Connection=True;TrustServerCertificate = True");
        }

        //public DbSet<Employee> Employees { get; set; }

        //tpcc
        public DbSet<FullTimeEmployees> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployees> PartTimeEmployees { get; set; }
        // wha is wrong 

    }
}
