using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class paymentconfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> p)
        {
            p.ToTable("Payment");
            p.HasKey(p=> p.Payment_id);
            p.Property(p => p.Payment_id)
                .UseIdentityColumn();
            p.Property(p=>p.Payment_status)
                .IsRequired(false)
                .HasMaxLength(50);
            p.HasOne(p => p.order)
                .WithOne(o => o.payment)
                .HasForeignKey<Order>(p => p.Order_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
