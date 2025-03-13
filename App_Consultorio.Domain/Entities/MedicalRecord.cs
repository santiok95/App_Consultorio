using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class MedicalRecord : IEntity
    {
        public MedicalRecord(Guid patientId, Guid? medicalConsultationId, string description, DateTime date)
        {
            PatientId = patientId;
            MedicalConsultationId = medicalConsultationId;
            Description = description;
            Date = date;
        }

        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid? MedicalConsultationId { get; set; }

        public required string Description { get; set; }
        public DateTime Date { get; set; }

        public required Patient Patient { get; set; }
        public required MedicalConsultation MedicalConsultation { get; set; }
    }
}
