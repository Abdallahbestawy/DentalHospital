using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Diagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int diagnosisId { get; set; }
        public string? Description { get; set; }
        
        public DateTime DateTime { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }
        [ForeignKey("Clinic")]
        public int clinicId { get; set; }
        public virtual Clinic Clinic { get; set; }
        [ForeignKey("InternDoctor")]
        public int interDoctorId { get; set; }
        public virtual InternDoctor InternDoctor { get; set; }
        public virtual List<Session> Sessions { get; set; }
        public virtual List<Radiology> Radiologies { get; set; }
        public virtual List<PatientChronicDiseases> PatientChronicDiseases { get; set; }
        public DiagnosisStatus diagnosisStatus { get; set; }
        public virtual Doctor Doctor { get; set; }

        
        
    }
}
