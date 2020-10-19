namespace ReminderLibrary
{
    public class MaintainableUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.Type Type { get; set; } //Will be used in a switch for parsing
        public MaintainableUnit(string name, System.Type type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}