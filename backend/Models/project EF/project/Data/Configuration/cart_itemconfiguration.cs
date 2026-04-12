using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class cart_itemconfiguration : IEntityTypeConfiguration<Cart_item>
    {
        public void Configure(EntityTypeBuilder<Cart_item> c)
        {
            c.ToTable("cart_items");
            c.HasKey(c => c.Cart_item_id);
            c.Property(c => c.Cart_item_id)
                .UseIdentityColumn();
            c.Property(c => c.quantity)
                .IsRequired();
            c.HasOne(c => c.product)
                .WithMany(p => p.cart_item)
                .HasForeignKey(c => c.product_id)
                .OnDelete(DeleteBehavior.Restrict);
            c.HasOne(c=> c.cart)
                .WithMany(ca => ca.cart_item)
                .HasForeignKey(c => c.cart_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
