using Gymagotchi.Data;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ApplicationDbContext _context;

        public ExerciseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddExerciseAsync(Exercise exercise)
        {
            bool isSuccess = false;
            try
            {
                _context.Exercises.Add(exercise);
                await _context.SaveChangesAsync();
                isSuccess = true;
            }
            catch
            {
                Console.WriteLine("Error.");
                //TODO : throw own Exception
            }
           
            return isSuccess;
        }
    }
}
