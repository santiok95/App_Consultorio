using App_Consultorio.Domain.Enums;

namespace App_Consultorio.Domain.Entities
{
    public class Doctor : IEntity
    {
        public Doctor(string applicationUserId, MedicalSpecialties medicalSpecialties, string? licenseNumber)
        {
            ApplicationUserId = applicationUserId;
            MedicalSpecialties = medicalSpecialties;
            LicenseNumber = licenseNumber;
            MedicalConsultations = new HashSet<MedicalConsultation>();
        }

        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }

        public MedicalSpecialties MedicalSpecialties { get; set; }
        public string? LicenseNumber { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }
        public ICollection<MedicalConsultation>? MedicalConsultations { get; set; }
    }
}
