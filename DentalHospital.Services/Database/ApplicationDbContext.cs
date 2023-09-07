using DentalHospital.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalHospital.Services.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Cashier> Cashiers { get; set; }


        public DbSet<ChronicDiseases> ChronicDiseases { get; set; }
        public DbSet<ClinicDepartment> ClinicDepartments { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<InternDoctor> InternDoctor { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientChronicDiseases> PatientChronicDiseases { get; set; }
        public DbSet<Radiology> Radiologies { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
