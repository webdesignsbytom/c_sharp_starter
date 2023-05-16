


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            var myDictionary = new Dictionary<int, Item>();

            myDictionary.Add(1, new Item() { Name = "asdf", Value = 4 });
            myDictionary.Add(2, new Item() { Name = "fdsa", Value = 5 });
            myDictionary.Add(3, new Item() { Name = "eeee", Value = 1 });

            foreach (Item item in myDictionary.Values)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(string.Join(Environment.NewLine, myDictionary.Select(d => d.Value).Select(d => $"{d.Name}- {d.Value}")));
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }
    }
    
}