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
    internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.Phone).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(100);
        }
    }
}
