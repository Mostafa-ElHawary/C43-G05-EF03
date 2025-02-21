using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C43_G05_EF03.Entities;
using Microsoft.EntityFrameworkCore;

namespace C43_G05_EF03.Context
{
    internal class AppDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF03;Trusted_Connection=True;TrustServerCertificate = True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
