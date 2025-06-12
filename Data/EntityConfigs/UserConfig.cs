using api.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data.EntityConfigs;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("UserTable");
        builder.Property(b => b.RowVersion).IsRowVersion();
        builder.Property(p => p.UserId).ValueGeneratedOnAdd();
        builder.HasMany(ur => ur.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(u => u.UserId);
    }
}

