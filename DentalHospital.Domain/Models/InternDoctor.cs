using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class InternDoctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int internDoctorId { get; set; }
        [Required]
        public string universityId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Diagnosis> Diagnoses { get; set; }  
        public virtual List<Session> Sessions { get; set; }
    }
}
 