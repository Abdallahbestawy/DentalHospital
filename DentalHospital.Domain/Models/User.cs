using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Domain.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; } 
        [Required,MaxLength(1500)]
        public string Name { get; set; }
        public int age { get; set; }

        [Required, MaxLength(11)]
        public string phoneNumber { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public Gender Gender { get; set; } 
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual InternDoctor InternDoctor { get; set; }
        public virtual Staff Staff { get; set; }    


    }
}
