using Gymagotchi.Data;
using Gymagotchi.Interfaces;
using Gymagotchi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Gymagotchi.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ApplicationDbContext _context;

        public ExerciseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Exercise> GetExercises()
        {
            var exercises = _context.Exercises.ToList();

            return exercises;
        }

        public Exercise GetExerciseById(Guid id)
        {
            var exercise = _context.Exercises.Include(c => c.ExerciseCategory).Include(c => c.ExerciseMode).FirstOrDefault(e => e.Id == id);
            return exercise;
        }

        public void DeleteExerciseById(Guid id)
        {
            var exercise = _context.Exercises.FirstOrDefault(e => e.Id == id);
            _context.Exercises.Remove(exercise);
            _context.SaveChanges();
        }

        public void UpdateExercise(Exercise exercise)
        {
            _context.Exercises.Update(exercise);
            _context.SaveChanges();
        }

        public void AddExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
        }

        public ExerciseCategory GetExerciseCategory(int exerciseCategoryId)
        {
            return _context.ExerciseCategories.FirstOrDefault(c => c.Id == exerciseCategoryId);
        }

        public ExerciseMode GetExerciseMode(int exerciseModeId)
        {
            return _context.ExerciseModes.FirstOrDefault(c => c.Id == exerciseModeId);
        }
    }
}
