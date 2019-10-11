
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
            return View("Index");
        }
    }
}
