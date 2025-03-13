using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class Expenses : IEntity
    {
        public Expenses(Guid? doctorId, Guid? medicalConsultationId, decimal amount, DateTime date, string? description)
        {
            DoctorId = doctorId;
            MedicalConsultationId = medicalConsultationId;
            Amount = amount;
            Date = date;
            Description = description;

        }

        public Guid Id { get; set; }
        public Guid? DoctorId { get; set; }
        public Guid? MedicalConsultationId { get; set; }


        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }

        public Doctor? Doctor { get; set; }
        public MedicalConsultation? MedicalConsultation { get; set; }
    }
}
