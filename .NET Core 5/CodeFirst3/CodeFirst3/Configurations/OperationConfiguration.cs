using CodeFirst3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CodeFirst3.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.StudentID, x.BookID });
            builder.ToTable("Operasyonlar");
            builder.HasOne(o => o.Book).WithMany(b => b.Operations).HasForeignKey(o => o.BookID);
            builder.HasOne(o => o.Student).WithMany(s => s.Operations).HasForeignKey(o => o.StudentID);

            builder.Property(x => x.StartDate).HasColumnType("datetime");


        }
    }
}
