using System;

namespace ReminderLibrary
{
    public class Task
    {
        public int Id { get; set; }
        public int MaintainableId { get; set; }
        public Maintainable Maintainable { get; set; }
        public int DefaultTaskId { get; set; }
        public TaskDefault DefaultTask { get; set; }
        public string Due { get; set; }
        public string CompletedAt { get; set; }
        public bool IsDone { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }       
    }
}