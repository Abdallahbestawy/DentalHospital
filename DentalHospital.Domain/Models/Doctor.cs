using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int doctorId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Clinic")]
        public int clinicId { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual List<Diagnosis> Diagnoses { get; set; }
        public virtual List<Radiology> Radiologies { get; set; }
    }
}
