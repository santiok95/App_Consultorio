using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Domain.Entities
{
    public class Patient : IEntity
    {
        public Patient(string name, string? description, string? phone, string? email, int age)
        {
            Name = name;
            Description = description;
            Phone = phone;
            Email = email;
            Age = age;
            MedicalRecords = new HashSet<MedicalRecord>();
            MedicalConsultations = new HashSet<MedicalConsultation>();
        }

        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }

        public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        public ICollection<MedicalConsultation>? MedicalConsultations { get; set; }
    }
}
