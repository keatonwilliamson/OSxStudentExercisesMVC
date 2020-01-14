using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace StudentExercises.Models
{
    public class Cohort
    {

        // public Cohort()
        // {
        //     this.Students = new HashSet<Student>();
        // }
        public int Id { get; set; }
        public string CohortName { get; set; }

        [NotMapped]
        // public virtual ICollection<Student> Students { get; set; }
        public List<Student> Students { get; set; }

        [NotMapped]
        public List<Instructor> Instructors { get; set; }
    }
}