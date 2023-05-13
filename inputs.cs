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

// Key input
private static void ReadKeys()
        {
            Console.WriteLine("..........");

            ConsoleKeyInfo key = new ConsoleKeyInfo();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("Yes was selected");
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("No was selected");
                        break;

                }

            
        }