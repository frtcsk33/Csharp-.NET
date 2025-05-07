using CodeFirst3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CodeFirst3.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar(30)"); //true
            builder.Property(x => x.LastName).IsRequired();
            builder.HasOne(s => s.StudentDetail)
             .WithOne(sd => sd.Student)
             .HasForeignKey<StudentDetail>
             (sd => sd.StudentID);

        }
    }
}
