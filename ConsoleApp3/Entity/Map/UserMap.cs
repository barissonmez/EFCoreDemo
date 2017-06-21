using ConsoleApp3.Entity.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp3.Entity.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            
            builder.HasKey(a=> a.ID);

            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);

            builder.Property(b => b.Age).IsRequired();


        }
    }
}
