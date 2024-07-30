using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Configurations
{
    public class VisitConfig : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.HasKey(v => v.VisitId);
            builder.Property(v => v.VisitId)
                   .IsRequired();
            builder.HasOne(v => v.Owner)
                   .WithMany(o => o.Visits)
                   .HasForeignKey(v => v.OwnerId);
        }
    }
}
