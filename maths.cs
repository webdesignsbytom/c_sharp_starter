int num = Convert.ToInt32("45");
int num2 = Convert.ToInt32(Console.ReadLine());
// for decimaals use doube and toDouble            
double num = Convert.ToDouble("45");
double num2 = Convert.ToDouble(Console.ReadLine());

using System;

// Maths
namespace ExampleProj
{
    class Program
    { 
        public static void Main(string[] args)
        {
            int number = 4;
            number++;
            System.Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}

// Add two binary numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1, b2;
            int i = 0, rem = 0;
            int[] sum = new int[20];
            Console.WriteLine("Enter the first binary number: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second binary number: ");
            b2 = int.Parse(Console.ReadLine());
            while (b1 != 0 || b2 != 0)
            {
                sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
                rem = (b1 % 10 + b2 % 10 + rem) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if (rem != 0)
                sum[i++] = rem;
            --i;
            Console.WriteLine("Sum of two binary numbers: ");
            while (i >= 0)
                Console.Write("{0}", sum[i--]);
            Console.ReadLine();
        }
    }
}

// Division 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number :");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Entered Number is Divisible by 2 ");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Divisible by 2");
            }
            Console.ReadLine();
        }
    }
}