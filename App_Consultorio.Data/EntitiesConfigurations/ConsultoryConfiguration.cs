using App_Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Data.EntitiesConfigurations
{
    internal class ConsultoryConfiguration : IEntityTypeConfiguration<Consultory>
    {
        public void Configure(EntityTypeBuilder<Consultory> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired();

            builder.Property(c => c.Address)
                   .HasMaxLength(255);
        }
    }
}
