using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class productconfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> p)
        {
            p.ToTable("products");
            p.HasKey(p => p.product_id);
            p.Property(p => p.product_id)
                .UseIdentityColumn();
            p.Property(p => p.name)
                .HasMaxLength(100)
                .IsRequired();
            p.Property(p => p.price)
                .IsRequired()
                .HasColumnType("money");
            p.HasOne(p => p.category)
                .WithMany(c => c.products)
                .HasForeignKey(p => p.category_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
