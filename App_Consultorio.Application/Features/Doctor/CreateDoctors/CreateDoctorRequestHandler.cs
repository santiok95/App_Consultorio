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

            var existingDoctor = await _context.Doctors
                .Where(x => x.LicenseNumber != null && x.LicenseNumber.Equals(request.LicenseNumber, StringComparison.OrdinalIgnoreCase)
                     || x.ApplicationUserId == request.ApplicationUserId)
                .FirstOrDefaultAsync();

            if (existingDoctor != null)
            {
                if (existingDoctor.LicenseNumber == request.LicenseNumber)
                    return "Ya existe un médico con esa matrícula";

                return  "Ya está registrado como médico";
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
