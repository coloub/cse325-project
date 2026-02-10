
using System;
namespace AcademicTaskManager.Models
{
    public enum TaskStatus
    {
        Pending = 0,
        InProgress = 1,
        Completed = 2
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
    }
}