using System;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Title { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha límite es obligatoria")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(TaskItem), nameof(ValidateDueDate))]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        [Required(ErrorMessage = "El proyecto es obligatorio")]
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public static ValidationResult? ValidateDueDate(DateTime dueDate, ValidationContext context)
        {
            if (dueDate < DateTime.Today)
                return new ValidationResult("La fecha límite debe ser futura");
            return ValidationResult.Success;
        }
    }
}