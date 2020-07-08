using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class AppconfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            //Đặt tên bảng lưu SQl
            builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Key);
            //Bắt buộc không để rỗng
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
