using Microsoft.EntityFrameworkCore;
using AcademicTaskManager.Models;

namespace AcademicTaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Proyecto 1", Description = "Descripción del Proyecto 1" },
                new Project { Id = 2, Name = "Proyecto 2", Description = "Descripción del Proyecto 2" }
            );

            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Tarea 1", Description = "Primera tarea", DueDate = DateTime.Now.AddDays(7), IsCompleted = false, ProjectId = 1 },
                new TaskItem { Id = 2, Title = "Tarea 2", Description = "Segunda tarea", DueDate = DateTime.Now.AddDays(14), IsCompleted = false, ProjectId = 1 },
                new TaskItem { Id = 3, Title = "Tarea 3", Description = "Tercera tarea", DueDate = DateTime.Now.AddDays(10), IsCompleted = true, ProjectId = 2 }
            );
        }
    }
}