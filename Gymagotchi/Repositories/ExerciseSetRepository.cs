using System;
using System.Collections.Generic;
using System.Linq;
using Gymagotchi.Data;
using Gymagotchi.Models;
using Gymagotchi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public void AssignWorkout(List<Guid> exerciseSetsIds, Workout workout)
        {
            var exerciseSets = _context.ExerciseSets.Where(e => exerciseSetsIds.Contains(e.Id)).ToList();
            foreach (var el in exerciseSets)
            {
                el.AssignWorkout(workout);
                _context.ExerciseSets.Update(el);
            }
            _context.SaveChanges();
        }

        public void DeleteExerciseSetById(Guid id)
        {
            var exerciseSet = _context.ExerciseSets.FirstOrDefault(c => c.Id == id);
            _context.ExerciseSets.Remove(exerciseSet);
            _context.SaveChanges();
        }

        public ExerciseSet GetExerciseSetById(Guid id)
        {
            var exerciseSet = _context.ExerciseSets.Include(c => c.Exercise).FirstOrDefault(e => e.Id == id);
            return exerciseSet;
        }

        public List<ExerciseSet> GetExerciseSets(List<Guid> exerciseSetsIds)
        {
            var exerciseSets = _context.ExerciseSets.Where(e => exerciseSetsIds.Contains(e.Id)).ToList();
            return exerciseSets;
        }

        //public IList<ExerciseSet> GetExerciseSetsByUser(Guid userId)
        //{
        //    return _context.ExerciseSets.Where(e => e.User.Id == userId.ToString()).ToList();
        //}

        public void UpdateExerciseSet(ExerciseSet exerciseSet)
        {
            _context.ExerciseSets.Update(exerciseSet);
            _context.SaveChanges();
        }
    }
}
