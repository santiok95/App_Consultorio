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
    internal class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Amount).HasColumnType("decimal(18,2)");

            builder.HasOne(i => i.MedicalConsultation)
                   .WithMany()
                   .HasForeignKey(i => i.MedicalConsultationId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);
        }
    }
}
