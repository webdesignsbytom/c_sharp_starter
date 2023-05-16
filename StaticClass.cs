// Using the static keyword we can create a sharable variable
// Otherwise each object creates its won numcars 

namespace InterfacesLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static = modifier to delare a static memember, which belongs to the class itself rather than an object
            Car car1 = new Car("BMW");
            Car car2 = new Car("Ford");
            Car car3 = new Car("Lambo");

            // NON STATIC
            Console.WriteLine(car1.numCars);
            Console.WriteLine(car2.numCars); // Both return one because they have their own copy of numCars

            // Static
            Console.WriteLine(Car.numCarsStatic);

            Car.StartRace();

            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        // NON STATIC
        public int numCars;
        // STATIC
        public static int numCarsStatic;

        public Car(String model)
        {
            this.model = model;
            // NON STATIC
            numCars++;
            numCarsStatic++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun");
        }
    }

}