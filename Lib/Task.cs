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
        public Task(Maintainable theThing, TaskDefault defaults, string notes)
        {
            this.MaintainableId = theThing.Id;
            this.Maintainable = theThing;
            this.DefaultTaskId = defaults.Id;
            this.DefaultTask = defaults;
            this.CompletedAt = null;
            this.IsDone = false;
            this.Notes = notes;
            this.Created = DateTime.Now;
            this.Completed = null;

            this.Due = "TODO";
            this.CompletedAt = "TODO";
        }
        private string GetDue()
        {
            return "TODO";
        }
        private void Complete()
        {
            
        }
    }
}