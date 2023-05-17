using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of game stat
            Console.WriteLine("Start");
            Character tom = new Character();
            tom.PrintName();
            tom.MySack.AddItem();
            tom.MySack.SubDictionaryUsingForEach();
            Console.WriteLine("Item " + tom.MySack.Capacity);
            // Hold end of program
            Console.ReadLine();
        }
    }

    public class Character
    {
        public string Name { get; set; } = "Springsteen";
        // Call the console write and creates
        public Backpack MySack = new Backpack();
        
        public void PrintName()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void PrintBackpack()
        {
            Console.WriteLine("SAck" + MySack);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
 
    }

    public class Backpack
    {
        Dictionary<int, Item> myBackpack = new Dictionary<int, Item>();
        public int Capacity { get; set; } = 50;

        public Backpack()
        {
            myBackpack.Add(1, new Item() { Name = "Goose", Value = 4 });
            myBackpack.Add(2, new Item() { Name = "Truck", Value = 7 });
            myBackpack.Add(3, new Item() { Name = "Harp", Value = 22 });
        }

        public void AddItem()
        {
            Console.WriteLine("ADDIng item");
            myBackpack.Add(4, new Item() { Name = "FIre stick", Value = 22 });
        }

        public void SubDictionaryUsingForEach()
        {
            foreach (Item item in myBackpack.Values)
            {
                Console.WriteLine("Item " + item.Name);
            }
        }
    }
}