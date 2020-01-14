using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentExercises.Models
{
    public class Student
    {
        // public Student()
        // {
        //     this.Exercises = new HashSet<Exercise>();
        // }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int? CohortId { get; set; }
        public virtual Cohort Cohort { get; set; }
        [NotMapped]
        // public virtual ICollection<Exercise> Exercises { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}