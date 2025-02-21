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
    internal class FullTimeEmployeesConfiguration : IEntityTypeConfiguration<FullTimeEmployees>
    {
        public void Configure(EntityTypeBuilder<FullTimeEmployees> builder)
        {
            builder.Property(f => f.Salary).IsRequired().HasColumnType("decimal(18,2)");
            // Add other property configurations as needed
        }
    }
}
