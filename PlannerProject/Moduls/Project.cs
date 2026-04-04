using System.Diagnostics;

namespace PlannerProject.Moduls
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Active";


        // Connection Project With many Process
        public List<Process> Processes { get; set; } = new();
    }
}
