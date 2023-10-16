using BaseProject.Data.Entities;
using BaseProject.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BaseProject.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.PhoneNumber).IsRequired(false);
            builder.Property(x => x.Gender).HasDefaultValue(Gender.Không);          
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(500);
        }
    }
}
