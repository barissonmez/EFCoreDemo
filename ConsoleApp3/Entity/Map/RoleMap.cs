using ConsoleApp3.Entity.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp3.Entity.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public override void Map(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            
            builder.HasKey(a=> a.ID);

            builder.Property(b => b.Name).IsRequired().HasMaxLength(100);




        }
    }
}
