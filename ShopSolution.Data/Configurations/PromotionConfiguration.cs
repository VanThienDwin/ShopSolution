using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x => new { x.Id, x.CategoryId, x.ProductId });
            builder.HasOne(x => x.Category).WithOne(x => x.Promotion).HasForeignKey<Category>(x => x.PromotionId);
            builder.HasOne(x => x.Product).WithOne(x => x.Promotion).HasForeignKey<Product>(x => x.PromotionId);
        }
    }
}
