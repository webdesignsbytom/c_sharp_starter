// Like a parent class or base class
// precded nmae with I
namespace InterfacesLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Create an instance of rabbit.
            // Class // Name // new // Class();
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            hawk.Hunt();
            rabbit.Flee();
            fish.Hunt();
            fish.Flee();

            Console.ReadKey();
        }
    }

    interface IPredator
    {
        void Hunt();
    }

    interface IPray
    {
        // Impletmenting the method is the job of the inheriting class
        void Flee();
    }

    public class Rabbit : IPray
    {
        public void Flee()
        {
            // Implements the method
            Console.WriteLine("Runs Away");
        }
    }

    public class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawnk is hunting for food");
        }
    }

    public class Fish : IPredator, IPray
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish hunts for food");
        }
    }
}