namespace ReminderLibrary
{
    public class MaintainableUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; } //Will be used in a switch for parsing
    }
}