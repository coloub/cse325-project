
using System.Collections.Generic;
namespace AcademicTaskManager.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string Description { get; set; } = string.Empty;

        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}