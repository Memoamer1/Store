using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class orderconfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> o)
        {
            o.ToTable("orders");
            o.HasKey(o => o.Order_id);
            o.Property(o => o.Order_id)
                .UseIdentityColumn();
            o.Property(o=>o.total_price)
                .IsRequired()
                .HasMaxLength(255);
            o.HasOne(o => o.user)
                .WithMany(u => u.orders)
                .HasForeignKey(o => o.user_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
