using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseTracker.Api.Models;

public class Exercise
{
    public int Id { get; set; }
    public string ExerciseName { get; set; } = string.Empty;
    public string? MuscleGroup { get; set; }
}