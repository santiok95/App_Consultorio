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
    internal class ExpensesConfiguration : IEntityTypeConfiguration<Expenses>
    {
        public void Configure(EntityTypeBuilder<Expenses> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(e => e.Description).HasMaxLength(255);

            builder.HasOne(e => e.Doctor)
                   .WithMany()
                   .HasForeignKey(e => e.DoctorId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);

            builder.HasOne(e => e.MedicalConsultation)
                   .WithMany()
                   .HasForeignKey(e => e.MedicalConsultationId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);
        }
    }
}
