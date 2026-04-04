using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace PlannerProject.Moduls
{
    public enum Theme
    {
        Dark,
        Light,
        System
    }

    public enum LanguageType
    {
        English,
        Serbian,
        German
    }

    public class Users
    {
        //Users Credentials
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        //Settings
        public Theme ThemePreference { get; set; } = Theme.Dark;
        public LanguageType PreferredLanguage { get; set; } = LanguageType.English;

        //Connection Between One User With Many Projectes
        public List<Project> Projects { get; set; } = new();
        //public List<Process> Processes { get; set; } = new();

    }
}
