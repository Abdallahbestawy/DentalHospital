using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class PatientChronicDiseases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int patientChronicDiseasesId { get; set; }
        [ForeignKey("ChronicDiseases")]
        public int chronicDiseasesId { get; set; }
        public virtual ChronicDiseases ChronicDiseases { get; set; }
        [ForeignKey("Diagnosis")]
        public int diagnosisId { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
    }
}
