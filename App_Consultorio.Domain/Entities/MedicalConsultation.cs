using App_Consultorio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class MedicalConsultation : IEntity
    {
        public MedicalConsultation(Guid? patientId, Guid doctorId, Guid consultoryId, DateTime date, string? reasonForConsultation, MedicalSpecialties medicalSpeciality, MedicalConsultationState medicalConsultationStatus)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            ConsultoryId = consultoryId;
            Date = date;
            ReasonForConsultation = reasonForConsultation;
            MedicalSpeciality = medicalSpeciality;
            MedicalConsultationStatus = medicalConsultationStatus;
            MedicalConsultationServices = new HashSet<MedicalConsultationService>();
        }

        public Guid Id { get; set; }
        public Guid? PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid ConsultoryId { get; set; }


        public DateTime Date { get; set; }
        public string? ReasonForConsultation { get; set; }
        public MedicalSpecialties MedicalSpeciality { get; set; }
        public MedicalConsultationState MedicalConsultationStatus { get; set; }

        public required Consultory Consultory { get; set; }
        public Patient? Patient { get; set; }
        public required Doctor Doctor { get; set; }
        public ICollection<MedicalConsultationService>? MedicalConsultationServices { get; set; }
    }
}
