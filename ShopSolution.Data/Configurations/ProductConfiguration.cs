using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Lưu tên bảng vào sql
            builder.ToTable("Products");
            //Khóa chính
            builder.HasKey(x=>new{x.Id,x.PromotionId});
            //Mặc định không để trống
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            //Giá trị mặc định là 0 và không đươc phép để trống
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

            //Liên kết 1 nhiều 1 cart có nhiều sp
            builder.HasOne(x => x.Cart).WithMany(x => x.Products).HasForeignKey(x => x.Id);

            //Liên kết 1-1
            builder.HasOne(a => a.ProductTranslation).WithOne(b => b.Product).HasForeignKey<ProductTranslation>(b => b.ProductId);//id của class ProductTranslation
;        }
    }

}
