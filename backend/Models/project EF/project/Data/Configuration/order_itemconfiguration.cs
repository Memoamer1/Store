using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class order_itemconfiguration : IEntityTypeConfiguration<Order_item>
    {
        public void Configure(EntityTypeBuilder<Order_item> o)
        {
            o.ToTable("order_items");
            o.HasKey(o=> o.Order_item_id);
            o.Property(o => o.Order_item_id)
                .UseIdentityColumn();
            o.Property(o => o.quantity)
                .HasMaxLength(100);
            o.HasOne(o => o.product)
                .WithMany(p => p.order_item)
                .HasForeignKey(o => o.product_id)
                .OnDelete(DeleteBehavior.Restrict);
            o.HasOne(o => o.order)
                .WithMany(p => p.order_items)
                .HasForeignKey(o => o.order_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
