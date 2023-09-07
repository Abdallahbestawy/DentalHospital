using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Cashier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cashierId { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }
        [ForeignKey("Staff")]
        public int staffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
