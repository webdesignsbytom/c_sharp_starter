// User input
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, World!");

            Console.ReadLine();
        }
    }
}

