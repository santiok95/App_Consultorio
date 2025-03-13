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
    internal class MedicalServiceConfiguration : IEntityTypeConfiguration<MedicalService>
    {
        public void Configure(EntityTypeBuilder<MedicalService> builder)
        {
            builder.HasKey(ms => ms.Id);

            builder.Property(ms => ms.MotiveOfTheMedicalConsultation).HasMaxLength(100);
            builder.Property(ms => ms.Price).HasColumnType("decimal(18,2)");
        }
    }
}
