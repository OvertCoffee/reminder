using System;
using System.Linq;
using System.Collections.Generic;
using ReminderLibrary;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            
            MaintainableUnit miles = new MaintainableUnit("Mile", typeof(int));
            MaintainableType car = new MaintainableType("Car", "Any automobile, including cars, trucks, vans, etc.");
            TaskDefault oilDefault = new TaskDefault("Change oil", car, 6000, miles, null, "Change the oil of this vehicle.");
            Maintainable myCar = new Maintainable("Red Civic", car, "2016 Honda Civic Sedan, CVT", 40000);

            WriteLine("Done");
        }
        private static void WriteLine(string msg = "")
        {
            msg = $"{DateTime.Now.ToString("yyyy.MM.dd_HH:mm:ss.fff")} = {msg.Trim()}";
            Console.WriteLine(msg);
        }
        /********************************************************************************/
        /********************************************************************************/
    }//class
}//namespace
