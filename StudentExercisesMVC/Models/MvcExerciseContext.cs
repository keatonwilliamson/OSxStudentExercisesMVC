using Microsoft.EntityFrameworkCore;  
  
namespace StudentExercises.Models  
{  
    public class MvcExerciseContext : DbContext  
    {  
        public MvcExerciseContext (DbContextOptions<MvcExerciseContext> options)  
            : base(options)  
        {  
        }  
  
        public DbSet<StudentExercises.Models.Exercise> Exercise { get; set; }  
    }  
}