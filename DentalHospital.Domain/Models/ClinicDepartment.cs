using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class ClinicDepartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clinicDepartmentId { get; set; }
        [Required,MaxLength(550)]
        public string clinicDepartmentName { get; set; }
        [ForeignKey("Clinic")]
        public int clinicId { get; set; }
        public virtual Clinic Clinic { get; set; }
    }
}
