using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int staffId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }  
        public virtual List<Cashier> Cashier { get; set; }  
        public virtual List<Radiology> Radiologies { get; set; }

    }
}
