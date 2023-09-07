using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int patientId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Cashier> Cashiers { get; set; }
        public virtual List<Diagnosis> Diagnoses { get; set; }

    }
}
