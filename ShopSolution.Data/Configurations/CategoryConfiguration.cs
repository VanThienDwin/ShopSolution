using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x=>new{x.Id,x.PromotionId});
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            //Liên kêt 1-1
            builder.HasOne(a => a.CategoryTranslation).WithOne(b => b.Category).HasForeignKey<CategoryTranslation>(b => b.CategoryId);//id của categorytranslation
        }
    }
}
