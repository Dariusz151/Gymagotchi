using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.Repositories.Interfaces;
using Gymagotchi.Requests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Requests.Commands.Handlers
{
    public class AddExerciseSetCommandHandler : ICommandHandler<AddExerciseSetCommand>
    {
        private readonly IExerciseSetRepository _exerciseSetRepository;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IUserRepository _userRepository;

        public AddExerciseSetCommandHandler(IExerciseSetRepository exerciseSetRepository, IExerciseRepository exerciseRepository, IUserRepository userRepository)
        {
            _exerciseSetRepository = exerciseSetRepository;
            _exerciseRepository = exerciseRepository;
            _userRepository = userRepository;
        }

        public void Handle(AddExerciseSetCommand command)
        {
            var exercise = _exerciseRepository.GetExerciseById(command.ExerciseId);
            var user = _userRepository.GetUserById(command.UserId);

            try
            {
                var exerciseSet = new ExerciseSet(
                        user,
                        exercise,
                        command.Repeats,
                        command.SetsAmount,
                        command.Load,
                        command.Timestamp
                        );
                _exerciseSetRepository.AddExerciseSet(exerciseSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                //TODO throw own Exception
            }
        }
    }
}
