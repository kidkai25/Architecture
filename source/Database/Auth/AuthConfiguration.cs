using Architecture.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Architecture.Database
{
    public sealed class AuthConfiguration : IEntityTypeConfiguration<AuthEntity>
    {
        public void Configure(EntityTypeBuilder<AuthEntity> builder)
        {
            builder.ToTable("Auths", "Auth");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Login).IsUnique();

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Login).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Salt).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Roles).IsRequired();
        }
    }
}
