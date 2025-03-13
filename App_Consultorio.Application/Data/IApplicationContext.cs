using App_Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Application.Data
{
    public interface IApplicationContext
    {
        public DbSet<Doctor> Doctors { get; }
        public DbSet<Income> Incomes { get; }
        public DbSet<Expenses> Expenses { get; }
        public DbSet<Consultory> Consultories { get; }
        public DbSet<MedicalConsultation> MedicalConsultations { get; }
        public DbSet<MedicalConsultationService> MedicalConsultationsServices { get; }
        public DbSet<MedicalService> MedicalServices { get; }
        public DbSet<MedicalRecord> MedicalRecords { get; }
        public DbSet<Patient> Patients { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();

        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
        Task RollbackTransactionAsync(CancellationToken cancellationToken);
        Task CommitTransactionAsync(CancellationToken cancellationToken);
    }
}
