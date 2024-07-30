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
    public class PetSpecializationConfig : IEntityTypeConfiguration<PetSpecialization>
    {
        public void Configure(EntityTypeBuilder<PetSpecialization> builder)
        {
           builder.HasKey(ps=> new {ps.PetId,ps.SpecializationId});
        }
    }
}
