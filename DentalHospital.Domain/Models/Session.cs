using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sessionId { get; set; }
        public string? Description { get; set; }
        public DateTime createdDate { get; set; }
        [ForeignKey("Diagnosis")]
        public int diagnosisId { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        [ForeignKey("InternDoctor")]
        public int internDoctorId { get; set; }
        public virtual InternDoctor InternDoctor { get; set; }  
    }
}
