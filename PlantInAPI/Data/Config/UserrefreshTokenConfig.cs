using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.Data.Config
{
    public class UserrefreshTokenConfig : IEntityTypeConfiguration<UserRefreshTokens>
    {
        public void Configure(EntityTypeBuilder<UserRefreshTokens> builder)
        {
            builder.ToTable("UserRefreshTokens");
            builder.HasKey(x => x.UserId);

            builder.Property(x => x.UserId)
                   .HasColumnName("user_id")  
                   .ValueGeneratedNever();
            builder.Property(x => x.RefreshToken).HasMaxLength(256).HasColumnName("refresh_token");
            builder.Property(x => x.RefreshTokenExpiryTime).HasColumnName("refresh_token_expiry_time");
        }
    }
}
