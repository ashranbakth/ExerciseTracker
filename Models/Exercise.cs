using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseTracker.Api.Models;

[Table("exercises")]
public class Exercise
{
    [Column("id")]
    public int Id { get; set; }
    [Column("exercise_name")]
    public string ExerciseName { get; set; } = string.Empty;
    [Column("muscle_group")]
    public string? MuscleGroup { get; set; }
}