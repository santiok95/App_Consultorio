using App_Consultorio.Application.Data;
using App_Consultorio.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>, IApplicationContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Expenses> Expenses => Set<Expenses>();
        public DbSet<Income> Incomes => Set<Income>();
        public DbSet<Consultory> Consultories => Set<Consultory>();
        public DbSet<MedicalConsultation> MedicalConsultations => Set<MedicalConsultation>();
        public DbSet<MedicalConsultationService> MedicalConsultationsServices => Set<MedicalConsultationService>();
        public DbSet<MedicalService> MedicalServices => Set<MedicalService>();
        public DbSet<MedicalRecord> MedicalRecords => Set<MedicalRecord>();
        public DbSet<Patient> Patients => Set<Patient>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken) => Database.BeginTransactionAsync(cancellationToken);
        public Task RollbackTransactionAsync(CancellationToken cancellationToken) => Database.RollbackTransactionAsync(cancellationToken);
        public Task CommitTransactionAsync(CancellationToken cancellationToken) => Database.CommitTransactionAsync(cancellationToken);
    }
}
