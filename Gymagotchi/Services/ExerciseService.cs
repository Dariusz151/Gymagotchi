using Gymagotchi.Commands;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        
        public async Task<bool> AddExerciseAsync(AddExerciseCommand command)
        {
            bool isSuccess = false;
            try
            {
                var exercise = new Exercise(
                        command.Name,
                        command.Desc,
                        command.ExerciseCategory,
                        command.ExerciseMode
                        );
                await _exerciseRepository.AddExerciseAsync(exercise);

                isSuccess = true;
            }
            catch
            {
                Console.WriteLine("Error");
                //TODO throw own Exception
            }
            
            return isSuccess;
        }

        public IEnumerable<ExerciseCategory> GetExerciseCategories()
        {
            var exerciseCategories = Enum.GetValues(typeof(ExerciseCategory))
                .Cast<ExerciseCategory>()
                .ToList();

            return exerciseCategories;
        }

        public IEnumerable<ExerciseMode> GetExerciseModes()
        {
            var exerciseModes = Enum.GetValues(typeof(ExerciseMode))
                .Cast<ExerciseMode>()
                .ToList();

            return exerciseModes;
        }
    }
}
