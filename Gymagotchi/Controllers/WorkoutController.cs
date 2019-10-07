using Gymagotchi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            var exerciseViewModel = new ExerciseViewModel();
            var exerciseSetViewModel = new ExerciseSetViewModel();

            exerciseSetViewModel.Exercise = exerciseViewModel;
            exerciseSetViewModel.Repeats = 0;
            exerciseSetViewModel.SetsAmount = 0;

            List<ExerciseSetViewModel> exerciseSetViewModelList = new List<ExerciseSetViewModel>();
            exerciseSetViewModelList.Add(exerciseSetViewModel);
            
            var workoutFormViewModel = new WorkoutFormViewModel();
            workoutFormViewModel.Exercises = exerciseSetViewModelList;

            return View("Index", workoutFormViewModel);
        }
    }
}
