using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using C43_G05_EF03.Entities;
using Microsoft.EntityFrameworkCore;

namespace C43_G05_EF03.Context
{
    internal class AppDpContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TPH
            //modelBuilder.Entity<FullTimeEmployees>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployees>().HasBaseType<Employee>();

            //TPC
            //modelBuilder.Entity<FullTimeEmployees>().ToTable("Employee");
            //modelBuilder.Entity<FullTimeEmployees>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployees>().ToTable("PartTimeEmployees");

            //TPCC

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
            
        }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF03;Trusted_Connection=True;TrustServerCertificate = True");
        }

        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        //tpcc
        public DbSet<FullTimeEmployees> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployees> PartTimeEmployees { get; set; }
        // wha is wrong 

    }
}
