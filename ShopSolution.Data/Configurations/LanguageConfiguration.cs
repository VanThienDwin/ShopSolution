using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>

    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.CategoryTranslation).WithMany(x => x.Languages).HasForeignKey(x => x.CategoryTranslationId);
            builder.HasOne(x => x.ProductTranslation).WithMany(x => x.Languages).HasForeignKey(x => x.ProductTranslationId);
        }
    }
}
