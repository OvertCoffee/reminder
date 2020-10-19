namespace ReminderLibrary
{
    public class TaskDefault
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public MaintainableType Type { get; set; }
        public double DurationValue { get; set; }
        public int UnitId { get; set; }
        public MaintainableUnit MaintainableUnit { get; set; }
        public int? Severity { get; set; }
        public string Description { get; set; }
        public TaskDefault(string name, MaintainableType type, double duration, MaintainableUnit unit, int? severity, string description)
        {
            this.Name = name;
            this.TypeId = type.Id;
            this.Type = type;
            this.DurationValue = duration;
            this.UnitId = unit.Id;
            this.MaintainableUnit = unit;
            this.Severity = severity;
            this.Description = description;
        }
    }
}