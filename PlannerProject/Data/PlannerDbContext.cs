using Microsoft.EntityFrameworkCore;
using PlannerProject.Moduls;

namespace PlannerProject.Data
{
    public class PlannerDbContext : DbContext
    {
        public PlannerDbContext(DbContextOptions<PlannerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships if needed
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Processes)
                .WithOne(p => p.Project)
                .HasForeignKey(p => p.ProjectId);

            modelBuilder.Entity<Process>()
                .HasMany(p => p.Tasks)
                .WithOne(p => p.Process)
                .HasForeignKey(p => p.ProcessId);
        }
    }
}
