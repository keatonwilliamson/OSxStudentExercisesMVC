using System.ComponentModel.DataAnnotations.Schema;

namespace StudentExercises.Models
{
    public class StudentCohort
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        // [NotMapped]
        public Student Student { get; set; }

        public int CohortId { get; set; }
        // [NotMapped]
        public Cohort Cohort { get; set; }
    }
}