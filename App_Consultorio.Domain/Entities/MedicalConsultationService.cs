using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class MedicalConsultationService : IEntity
    {
        public MedicalConsultationService(Guid medicalConsultationId, Guid medicalServiceId, decimal finalPrice)
        {
            MedicalConsultationId = medicalConsultationId;
            MedicalServiceId = medicalServiceId;
            FinalPrice = finalPrice;
        }

        public Guid Id { get; set; }
        public Guid MedicalConsultationId { get; set; }
        public Guid MedicalServiceId { get; set; }

        public decimal FinalPrice { get; set; }

        public required MedicalConsultation MedicalConsultation { get; set; }
        public required MedicalService MedicalService { get; set; }

    }
}
