using Gymagotchi.Commands;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Gymagotchi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gymagotchi.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        public IActionResult Form()
        {
            var exerciseModes = _exerciseService.GetExerciseModes();
            var exerciseCategories = _exerciseService.GetExerciseCategories();

            var exerciseFormViewModel = new ExerciseFormViewModel(exerciseCategories, exerciseModes);

            return View("ExerciseForm", exerciseFormViewModel);
        }
    }
}