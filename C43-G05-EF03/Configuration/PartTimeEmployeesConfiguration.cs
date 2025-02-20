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
    internal class PartTimeEmployeesConfiguration : IEntityTypeConfiguration<PartTimeEmployees>
    {
        public void Configure(EntityTypeBuilder<PartTimeEmployees> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.HourlyRate).IsRequired().HasColumnType("decimal(18,2)");
            // Add other property configurations as needed
        }
    }
}
