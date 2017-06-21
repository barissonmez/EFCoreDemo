using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity.Configuration
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity:class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
