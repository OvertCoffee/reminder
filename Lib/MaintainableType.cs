namespace ReminderLibrary
{
    public class MaintainableType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MaintainableType(string name, string desc)
        {
            this.Name = name;
            this.Description = desc;
        }
    }
}