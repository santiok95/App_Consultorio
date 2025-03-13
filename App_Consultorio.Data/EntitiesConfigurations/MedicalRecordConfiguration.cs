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
    internal class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.HasKey(mr => mr.Id);

            builder.Property(mr => mr.Description).HasMaxLength(1000);

            builder.HasOne(mr => mr.Patient)
                   .WithMany(p => p.MedicalRecords)
                   .HasForeignKey(mr => mr.PatientId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(mr => mr.MedicalConsultation)
                   .WithMany()
                   .HasForeignKey(mr => mr.MedicalConsultationId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);
        }
    }
}
