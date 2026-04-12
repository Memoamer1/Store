using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class cartconfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> c)
        {
            c.ToTable("carts");
            c.HasKey(c=> c.Cart_id);
            c.Property(c => c.Cart_id)
                .UseIdentityColumn();
            c.HasOne(c => c.user)
                .WithOne(u => u.cart)
                .HasForeignKey<User>(c => c.user_id)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
