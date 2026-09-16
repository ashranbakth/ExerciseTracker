using ExerciseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace ExerciseTracker.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<User> Users => Set<User>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("id");
            
            entity.Property(e => e.ExerciseName)
                .HasColumnName("exercise_name");

            entity.Property(e => e.MuscleGroup)
                .HasColumnName("muscle_group");

        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.CreatedAt)
                .HasColumnName("created_at");
        });
    }
}