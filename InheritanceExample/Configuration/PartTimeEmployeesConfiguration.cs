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
