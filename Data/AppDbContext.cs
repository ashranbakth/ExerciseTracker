using ExerciseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Exercise> Exercises => Set<Exercise>();
}