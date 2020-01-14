using Microsoft.EntityFrameworkCore;
using StudentExercises.Models;
using System.Data;

namespace StudentExercises.Models
{
    public class MvcDatabaseContext : DbContext
    {
        public MvcDatabaseContext(DbContextOptions<MvcDatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<StudentExercises.Models.Exercise> Exercise { get; set; }
        public DbSet<StudentExercises.Models.Cohort> Cohort { get; set; }
        public DbSet<StudentExercises.Models.Student> Student { get; set; }
        public DbSet<StudentExercises.Models.StudentCohort> StudentCohorts { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Student>()
        //     .HasOne<Cohort>(s => s.Cohort)
        //     .WithMany(c => c.Students)
        //     .HasForeignKey(s => s.CohortId);
        // }
    }
}