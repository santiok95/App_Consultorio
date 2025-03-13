using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class Income : IEntity
    {
        public Income(Guid? medicalConsultationId, decimal amount, DateTime date)
        {
            MedicalConsultationId = medicalConsultationId;
            Amount = amount;
            Date = date;
        }

        public Guid Id { get; set; }
        public Guid? MedicalConsultationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public MedicalConsultation? MedicalConsultation { get; set; }
    }
}
