using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Radiology
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int radiologyId { get; set; }
       public double radiologyValue { get; set; }
        public TypeRadiology typeRadiology { get; set; }
        public bool radiologyStatus { get; set; }
        [ForeignKey("Diagnosis")]
        public int diagnosisId { get; set; }
      
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
