using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class MedicalService : IEntity
    {
        public MedicalService(string motiveOfTheMedicalConsultation, decimal price)
        {
            MotiveOfTheMedicalConsultation = motiveOfTheMedicalConsultation;
            Price = price;
        }

        public Guid Id { get; set; }
        public required string MotiveOfTheMedicalConsultation { get; set; }
        public decimal Price { get; set; }
    }
}
