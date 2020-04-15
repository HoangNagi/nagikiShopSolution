using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using nagikiShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace nagikiShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(t => new { t.OrderId, t.ProductId});
            builder.HasOne(t => t.Order)
             .WithMany(pc => pc.OrderDetails)
             .HasForeignKey(pc => pc.OrderId);
            builder.HasOne(t => t.Product)
            .WithMany(pc => pc.OrderDetails)
            .HasForeignKey(pc => pc.ProductId);
        }
    }
}
