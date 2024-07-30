using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetShopManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Configurations
{
    public class SpecializationConfig: IEntityTypeConfiguration<Specialization>
    {
      public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            builder.HasKey(s=>s.SpecializationId);

            builder.HasMany(s => s.PetSpecializations)
                   .WithOne(ps => ps.Specialization)
                   .HasForeignKey(ps => ps.SpecializationId);
        }
    }
}
