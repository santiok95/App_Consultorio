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
    internal class MedicalConsultationServiceConfiguration : IEntityTypeConfiguration<MedicalConsultationService>
    {
        public void Configure(EntityTypeBuilder<MedicalConsultationService> builder)
        {
            builder.HasKey(mcs => mcs.Id);

            builder.Property(mcs => mcs.FinalPrice).HasColumnType("decimal(18,2)");

            // Relación con MedicalConsultation
            builder.HasOne(mcs => mcs.MedicalConsultation)
                   .WithMany(mc => mc.MedicalConsultationServices)
                   .HasForeignKey(mcs => mcs.MedicalConsultationId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Relación con MedicalService
            builder.HasOne(mcs => mcs.MedicalService)
                   .WithMany()
                   .HasForeignKey(mcs => mcs.MedicalServiceId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
