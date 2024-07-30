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
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
           builder.HasKey(o=> o.OwnerId);
            builder.HasMany(o => o.Visits)
                   .WithOne(v => v.Owner)
                   .HasForeignKey(v => v.OwnerId);
        }
    }
}
