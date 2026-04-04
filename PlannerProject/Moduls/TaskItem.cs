using System.ComponentModel.DataAnnotations;

namespace PlannerProject.Moduls
{
    public enum PriorityLevel
    {
        Low = 1,
        Medium = 2,
        High = 3,
        Urgent = 4 
    }

    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        [Required]
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;

        // Foreign Key For Process
        public int ProcessId { get; set; }
        public Process? Process { get; set; }
    }
}
