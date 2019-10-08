using System;
using System.Collections.Generic;
using System.Text;
using Gymagotchi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gymagotchi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Exercise>()
                .Property(e => e.ExerciseMode)
                .HasConversion(
                    v => v.ToString(),
                    v => (ExerciseMode)Enum.Parse(typeof(ExerciseMode), v));

            modelBuilder
               .Entity<Exercise>()
               .Property(e => e.ExerciseCategory)
               .HasConversion(
                   v => v.ToString(),
                   v => (ExerciseCategory)Enum.Parse(typeof(ExerciseCategory), v));

            base.OnModelCreating(modelBuilder);
        }
    }
}
