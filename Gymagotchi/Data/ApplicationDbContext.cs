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
     

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
