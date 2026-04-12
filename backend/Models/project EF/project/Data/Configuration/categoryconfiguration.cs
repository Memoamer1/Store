using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class categoryconfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> c)
        {
            c.ToTable("categories");
            c.HasKey(c => c.Category_id);
            c.Property(c => c.Category_id)
                .UseIdentityColumn();
            c.Property(c => c.category_name)
                .IsRequired()
                .HasMaxLength(50);
            c.HasIndex(c => c.category_name)
                .IsUnique(true);
        }
    }
}
