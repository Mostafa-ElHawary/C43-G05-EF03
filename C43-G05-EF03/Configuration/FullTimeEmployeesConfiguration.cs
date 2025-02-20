using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C43_G05_EF03.Entities;

namespace C43_G05_EF03.Configuration
{
    internal class FullTimeEmployeesConfiguration : IEntityTypeConfiguration<FullTimeEmployees>
    {
        public void Configure(EntityTypeBuilder<FullTimeEmployees> builder)
        {
            builder.Property(f => f.Salary).IsRequired().HasColumnType("decimal(18,2)");
            // Add other property configurations as needed
        }
    }
}
