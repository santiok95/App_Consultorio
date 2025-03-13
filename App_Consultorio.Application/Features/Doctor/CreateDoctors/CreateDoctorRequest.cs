using App_Consultorio.Application.Models;
using App_Consultorio.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Application.Features.Doctor.CreateDoctors
{
    public record CreateDoctorRequest(string ApplicationUserId, MedicalSpecialties MedicalSpecialties, string? LicenseNumber) : IRequest<Result>;
    
}
