using App_Consultorio.Domain.Entities;
using App_Consultorio.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Data.EntitiesConfigurations
{
    internal class MedicalConsultationConfiguration : IEntityTypeConfiguration<MedicalConsultation>
    {
        public void Configure(EntityTypeBuilder<MedicalConsultation> builder)
        {
            builder.HasKey(mc => mc.Id);

            builder.Property(mc => mc.ReasonForConsultation).HasMaxLength(255);

            builder.Property(mc => mc.MedicalConsultationStatus)
                  .HasDefaultValue(MedicalConsultationState.Pending);

            builder.HasOne(mc => mc.Doctor)
                   .WithMany(d => d.MedicalConsultations)
                   .HasForeignKey(mc => mc.DoctorId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(mc => mc.Patient)
                   .WithMany(p => p.MedicalConsultations)
                   .HasForeignKey(mc => mc.PatientId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);

            builder.HasOne(mc => mc.Consultory)
              .WithMany(c => c.MedicalConsultations)
              .HasForeignKey(mc => mc.ConsultoryId)
              .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
