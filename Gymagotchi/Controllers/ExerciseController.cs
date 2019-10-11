using Gymagotchi.Commands;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gymagotchi.Controllers
{
    public class ExerciseController : Controller
    {
        public ExerciseController()
        {
          
        }

        public IActionResult Form()
        {
            return View("ExerciseForm");
        }
    }
}