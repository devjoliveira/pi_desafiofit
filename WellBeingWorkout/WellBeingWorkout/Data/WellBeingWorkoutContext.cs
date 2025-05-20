using Microsoft.EntityFrameworkCore;
using System;
using WellBeingWorkout.Models;

namespace WellBeingWorkout.Data
{
    public class WellBeingWorkoutContext : DbContext
    {
        public WellBeingWorkoutContext(DbContextOptions<WellBeingWorkoutContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Challenge> Challenge { get; set; }
        public DbSet<UserChallenge> UserChallenge { get; set; }
    }
}
