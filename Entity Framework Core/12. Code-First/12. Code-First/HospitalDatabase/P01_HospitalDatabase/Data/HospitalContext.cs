using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<PatientMedicament> Prescriptions { get; set; }

        public DbSet<Visitation> Visitations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;DataBase=HospitalDatabase;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<PatientMedicament>(entity => {

                entity.HasKey(x => new { x.PatientId, x.MedicamentId });

              

                entity
                 .HasOne(x => x.Patient)
                 .WithMany(x => x.PatientsMedicaments)
                 .HasForeignKey(x => x.PatientId);

                entity
                    .HasOne(x => x.Medicament)
                    .WithMany(x => x.PatientMedicaments)
                    .HasForeignKey(x => x.MedicamentId);
            });

            modelBuilder.Entity<Diagnose>(entity =>
            {
                entity.HasKey(x => x.DiagnoseId);

                entity
                    .Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .Property(x => x.Comments)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(250);

                entity
                    .HasOne(x => x.Patient)
                    .WithMany(x => x.Diagnoses)
                    .HasForeignKey(x => x.PatientId);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(x => x.PatientId);

                entity
                    .Property(x => x.FirstName)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(50);

                entity
                    .Property(x => x.LastName)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Visitation>(entity =>
            {
                entity.HasKey(x => x.VisitationId);

                entity
                    .Property(x => x.Comments)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(250);

                entity
                    .HasOne(x => x.Patient)
                    .WithMany(x => x.Visitations)
                    .HasForeignKey(x => x.PatientId);

                entity
                    .HasOne(x => x.Doctor)
                    .WithMany(x => x.Visitations)
                    .HasForeignKey(x => x.DoctorId);

            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.HasKey(x => x.MedicamentId);

                entity
                    .Property(x => x.Name)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(x => x.DoctorId);

                entity
                    .Property(x => x.Name)
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasMaxLength(100);
            });
        }


    }
}
