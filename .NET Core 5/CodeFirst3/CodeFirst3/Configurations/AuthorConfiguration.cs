using CodeFirst3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CodeFirst3.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Yazarlar");
            builder.Property(x => x.FirstName).HasColumnName("İsim");
            builder.Property(x => x.LastName).HasColumnName("Soyisim");
        }
    }
}
