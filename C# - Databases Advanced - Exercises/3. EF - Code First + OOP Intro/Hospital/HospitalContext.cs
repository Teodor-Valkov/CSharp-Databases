namespace Hospital
{
    using System.Data.Entity;
    using Models;
    using Migrations;

    public class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("name=HospitalContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HospitalContext, Configuration>());
        }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Visitation> Visitations { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
    }
}