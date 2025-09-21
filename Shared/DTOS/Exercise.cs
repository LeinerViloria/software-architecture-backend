
namespace Roadmap.DTOS;

public record Exercise
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public HashSet<string> Concepts { get; set; } = [];
    public string Objective { get; set; } = string.Empty;
    public HashSet<string> Requirements { get; set; } = [];
    public HashSet<string> Hints { get; set; } = [];
    public List<ExerciseExample> Examples { get; set; } = [];
}