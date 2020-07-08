using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x=>new{x.ProductId,x.CategoryId});

            //Liên kết nhiều nhiều tạo ra bảng mới
            builder.HasOne(x=>x.Product).WithMany(px=>px.ProductInCategories).HasForeignKey(px=>px.ProductId);
            builder.HasOne(x => x.Category).WithMany(px => px.ProductInCategories).HasForeignKey(px => px.CategoryId);
        }
    }
}
