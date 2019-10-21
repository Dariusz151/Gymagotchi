using Gymagotchi.Data;
using Gymagotchi.Repositories.Interfaces;
using Gymagotchi.Models;
namespace Gymagotchi.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkoutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddWorkout(Workout workout)
        {
            _context.Workouts.Add(workout);
            _context.SaveChanges();
        }
    }
}
