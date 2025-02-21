using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Position).IsRequired().HasMaxLength(100);
            builder.HasDiscriminator<string>("EmployeeType")
                   .HasValue<FullTimeEmployees>("FullTime")
                   .HasValue<PartTimeEmployees>("PartTime");
            // Add other property configurations as needed
        }
    }
}
