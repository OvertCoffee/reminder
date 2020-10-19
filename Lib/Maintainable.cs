namespace ReminderLibrary
{
    public class Maintainable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public MaintainableType Type { get; set; }
        public string Description{ get; set; }
        public double? Mileage{ get; set; }
        public Maintainable(string name, MaintainableType type, string desc, double? miles)
        {
            this.Name = name;
            this.TypeId = type.Id;
            this.Type = type;
            this.Description = desc;
            this.Mileage = miles;
        }
    }
}