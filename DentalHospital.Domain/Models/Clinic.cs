using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Clinic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clinicId { get; set; }
        [Required,MaxLength(250)]
        public string clinicName { get; set; }
        public virtual List<ClinicDepartment> ClinicDepartments { get; set; }
        public virtual List<Diagnosis> Diagnoses { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}
