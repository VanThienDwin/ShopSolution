using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Configurations
{
    public class SystemActiveConfiguration : IEntityTypeConfiguration<SystemActive>
    {
     
        public void Configure(EntityTypeBuilder<SystemActive> builder)
        {
            builder.ToTable("SystemActives");
            builder.HasKey(x => x.Id);
        }
    }
}
