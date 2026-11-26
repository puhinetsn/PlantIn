using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.Property(p => p.Id).HasDefaultValueSql("uuidv7()").ValueGeneratedOnAdd();

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(128);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.XP)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.StreakCount)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.IsAdmin)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
