using App_Consultorio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class Consultory : IEntity
    {
        public Consultory(ConsultoryName name, string? address)
        {
            Name = name;
            Address = address;
            MedicalConsultations = new HashSet<MedicalConsultation>();
        }

        public Guid Id { get; set; }
        public ConsultoryName Name { get; set; }

        public string? Address { get; set; }

        public ICollection<MedicalConsultation>? MedicalConsultations { get; set; }
    }
}
