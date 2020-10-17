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

    }
}