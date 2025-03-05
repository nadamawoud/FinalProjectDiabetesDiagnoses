using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Repository.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Api
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<MedicalSyndicate> MedicalSyndicates { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Clerk> Clerks { get; set; }
        public DbSet<CasualUser> CasualUsers { get; set; }
        public DbSet<MedicalHistory> MedicalHistories { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientMedicalHistory> PatientMedicalHistories { get; set; }
        public DbSet<NewsFeedPost> NewsFeedPosts { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<SuspectDiabetesResult> SuspectDiabetesResults { get; set; }
        public DbSet<Symptoms> Symptoms { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Alarm> Alarms { get; set; }
        public DbSet<BloodSugarMeasurement> BloodSugarMeasurements { get; set; }
        public DbSet<ChatbotQuestionDoctor> ChatbotQuestionDoctors { get; set; }
        public DbSet<ChatbotQuestionCasualUser> ChatbotQuestionCasualUsers { get; set; }
        public DbSet<SuggestionFood> SuggestionFoods { get; set; }
        public DbSet<DiagnosisDisease> DiagnosisDiseases { get; set; }
        public DbSet<ManagerMedicalHistory> ManagerMedicalHistories { get; set; }
        public DbSet<CasualUserChatbotQuestionCasualUser> CasualUserChatbotQuestionCasualUsers { get; set; }
        public DbSet<DoctorChatbotQuestionDoctor> DoctorChatbotQuestionDoctors { get; set; }
        public DbSet<PatientDoctor> PatientDoctors { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }
    }
} 


    

