namespace AcademicTaskManager.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Status { get; set; }
    public DateTime DueDate { get; set; }
    public int ProjectId { get; set; }
}