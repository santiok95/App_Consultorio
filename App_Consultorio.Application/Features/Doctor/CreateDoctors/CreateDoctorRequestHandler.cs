using App_Consultorio.Application.Data;
using App_Consultorio.Application.Models;
using App_Consultorio.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Application.Features.Doctor.CreateDoctors
{
    public class CreateDoctorRequestHandler : IRequestHandler<CreateDoctorRequest, Result>
    {
        private readonly IApplicationContext _context;

        public CreateDoctorRequestHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(CreateDoctorRequest request, CancellationToken cancellationToken)
        {
            var userExists = await _context.Users
                .AnyAsync(u => u.Id == request.ApplicationUserId, cancellationToken);
            if (!userExists)
            {
               return "El usuario especificado no existe en el sistema.";
            }

            var doctor = new App_Consultorio.Domain.Entities.Doctor(
                request.ApplicationUserId,
                request.MedicalSpecialties,
                request.LicenseNumber
            );

            _context.Doctors.Add(doctor);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
