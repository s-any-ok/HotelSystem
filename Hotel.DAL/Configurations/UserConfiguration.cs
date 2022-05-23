using Hotel.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>

    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.Property(x => x.Login)
                .IsRequired();

            builder.HasAlternateKey(x => x.Login);

            builder.Property(x => x.Password)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.LastName)
                .IsRequired();
        }
    }
}