using Architecture.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Architecture.Database
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users", "User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Status).IsRequired();

            builder.OwnsOne(x => x.FullName, y =>
            {
                y.Property(x => x.Name).IsRequired().HasColumnName(nameof(FullName.Name)).HasMaxLength(100);
                y.Property(x => x.Surname).IsRequired().HasColumnName(nameof(FullName.Surname)).HasMaxLength(200);
            });

            builder.OwnsOne(x => x.Email, y =>
            {
                y.Property(x => x.Address).IsRequired().HasColumnName(nameof(UserEntity.Email)).HasMaxLength(300);
                y.HasIndex(x => x.Address).IsUnique();
            });

            builder.HasOne(x => x.Auth);
        }
    }
}
