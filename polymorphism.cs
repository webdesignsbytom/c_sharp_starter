// To have many forms
namespace PolyLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // Create an array of vehricle witg the data type of verchiles
            Vehicle[] vehicles = { car, bicycle, boat };

            // foreach // datatype // name of obj // in //  array to search
            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    // Base class or parent class 
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        // THESE classes all override the VEHCLE classes Go() method
        public override void Go()
        {
            Console.WriteLine("The Car is moving!!");
        }

    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Bike is moving!!");
        }

    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Boat is moving!!");
        }

    }
}