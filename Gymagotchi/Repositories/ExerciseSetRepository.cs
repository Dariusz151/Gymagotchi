using Gymagotchi.Data;
using Gymagotchi.Models;
using Gymagotchi.Repositories.Interfaces;

namespace Gymagotchi.Repositories
{
    public class ExerciseSetRepository : IExerciseSetRepository
    {
        private readonly ApplicationDbContext _context;

        public ExerciseSetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddExerciseSet(ExerciseSet exerciseSet)
        {
            _context.ExerciseSets.Add(exerciseSet);
            _context.SaveChanges();
        }
    }
}
