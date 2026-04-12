using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using project.Models;

namespace project.Data.Configuration
{
    internal class userconfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> u)
        {
            u.ToTable("users");
            u.HasKey(u => u.user_id);
            u.Property(u => u.user_id)
                .UseIdentityColumn();
            u.Property(u => u.name)
                .HasColumnType("varchar")
                .IsRequired(true)
                .HasMaxLength(100);
            u.Property(u => u.email)
                .IsRequired(true)
                .HasMaxLength(50);
            u.Property(u => u.password)
                .IsRequired(true)
                .HasMaxLength(50);
            u.Property(u => u.phone_number)
                .IsRequired(true)
                .HasMaxLength (11);
            u.Property(u => u.address)
                .IsRequired(false)
                .HasMaxLength(200);
            u.HasIndex(u => u.email)
                .IsUnique(true);
        }
    }
}
