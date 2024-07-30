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
    public class PetConfig : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {

            builder.HasKey(p => p.PetId);
            builder.HasOne(p => p.Owner)
                   .WithOne(o => o.Pet)
                   .HasForeignKey<Pet>(p => p.OwnerId);
            builder.HasMany(p => p.PetsSpecialization)
                   .WithOne(ps => ps.Pet)
                   .HasForeignKey(ps => ps.PetId);
        }
    }
}
