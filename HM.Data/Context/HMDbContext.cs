using HM.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HM.Data.Context
{
    public class HMDbContext : DbContext
    {
        //public HMDbContext(DbContextOptions<HMDbContext> options) : base(options)
        //{
        //    Database.Migrate();
        //}

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<VisitingDate> VisitingDates { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public DbSet<DoctorVisitingDate> DoctorVisitingDates { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }
        public DbSet<DiagnosisSymptom> DiagnosisSymptoms { get; set; }
        public DbSet<DiagnosisMedicine> DiagnosisMedicines { get; set; }
        public DbSet<DiagnosisLabTest> DiagnosisLabTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string SqlConnectionString = "Server=.\\SQLEXPRESS; Database=HospitalManagementDB; Trusted_Connection=True";
            builder.UseSqlServer(SqlConnectionString);
            base.OnConfiguring(builder);
        }
    }
}
