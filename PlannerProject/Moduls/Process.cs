namespace PlannerProject.Moduls
{
    public class Process
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // exp. "Security", "Requirements"

        // Foreign Key For Project
        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        // Connecton BEetween Porcess and many Tasks
        public List<TaskItem> Tasks { get; set; } = new();
    }
}
