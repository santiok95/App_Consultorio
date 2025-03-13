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
    internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.LicenseNumber).HasMaxLength(50);

            builder.Property(d => d.MedicalSpecialties).HasDefaultValue(MedicalSpecialties.None);

            builder.HasOne(d => d.ApplicationUser)
                   .WithOne()
                   .HasForeignKey<Doctor>(d => d.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
