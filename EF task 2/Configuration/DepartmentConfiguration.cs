using EF_task_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DeptId);
            builder.Property(x => x.DeptId).UseIdentityColumn(10, 10);
            //builder.Property(x => x.DeptId).HasDefaultValueSql("NewGuid()");
            builder.Property(x => x.Name).HasColumnName("DepartmentName").HasColumnType("varchar").HasMaxLength(50).IsRequired(false).HasDefaultValue("HR");
            builder.Property(x => x.DateOfCreation).HasAnnotation("DataType", "Date").HasDefaultValueSql("GetDate()")/*.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))*/;
            builder.Ignore(x => x.Serial);
        }
    }
}
