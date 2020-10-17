using System;
using Microsoft.EntityFrameworkCore;
using ReminderLibrary;

namespace api
{
    public class ReminderContext : DbContext
    {
        private static readonly string host = "db";
        private static readonly string database = Environment.GetEnvironmentVariable("POSTGRES_DB");
        private static readonly string username = Environment.GetEnvironmentVariable("POSTGRES_USER");
        private static readonly string password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
        
        private static readonly string connString = $"Host={host};Database={database};Username={username};Password={password}";
        public DbSet<Maintainable> Maintainables { get; set; }
        public DbSet<MaintainableType> MaintainableTypes { get; set; }
        public DbSet<MaintainableUnit> MaintainableUnits { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskDefault> TaskDefaults { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(connString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Maintainable */
            modelBuilder.Entity<Maintainable>().HasKey(m => m.Id);
            modelBuilder.Entity<Maintainable>().HasIndex(m => m.Name).IsUnique();
            
            /* MaintainableType */
            modelBuilder.Entity<MaintainableType>().HasKey(m => m.Id);
            modelBuilder.Entity<MaintainableType>().HasIndex(m => m.Name).IsUnique();
            
            /* MaintainableUnits */
            modelBuilder.Entity<MaintainableUnit>().HasKey(m => m.Id);
            modelBuilder.Entity<MaintainableUnit>().HasIndex(m => m.Name).IsUnique();
            
            /* Tasks */
            modelBuilder.Entity<Task>().HasKey(t => t.Id);
            modelBuilder.Entity<Task>().HasIndex(t => new {t.MaintainableId, t.Due});
            modelBuilder.Entity<Task>().HasIndex(t => new {t.MaintainableId, t.DefaultTaskId, t.Due}).IsUnique();
            modelBuilder.Entity<Task>().HasIndex(t => t.Due);
            
            /* TaskDefaults */
            modelBuilder.Entity<TaskDefault>().HasKey(t => t.Id);
            modelBuilder.Entity<TaskDefault>().HasIndex(t => new {t.Name, t.TypeId}).IsUnique();
        }
    }
}