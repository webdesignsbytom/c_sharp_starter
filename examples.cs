// Check for key press
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                MessageBox.Show("Enter key pressed");
        }
    }
}


// Extend class with inheritence
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher d = new Teacher();
            d.Teach();
            Student s = new Student();
            s.Learn();
            s.Teach();
            Console.ReadKey();
        }
        class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Teacher
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}

// Date time
using System;
class CompareDates
{
 
    public static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime yesterday = today - new TimeSpan(1, 0, 0, 0);
        DateTime tomorrow = today + new TimeSpan(1, 0, 0, 0);
        Console.WriteLine("Yesterday was     {0}", yesterday);
        Console.WriteLine("Today     is      {0}", today);
        Console.WriteLine("Tomorrow  will be {0}", tomorrow);
        Console.WriteLine("\nIs yesterday less than today?   {0}.",
           yesterday < today);
        Console.WriteLine("Is today the same as tomorrow ? {0}.",
           today == tomorrow);
 
        TimeSpan totalTimespan = new TimeSpan(3, 5, 24, 17) +
                                 new TimeSpan(1, 18, 35, 43);
        Console.WriteLine(
           "\nThe length of the period is {0} days {1} hours" +
           " {2} minutes {3} seconds.",
           totalTimespan.Days, totalTimespan.Hours,
           totalTimespan.Minutes, totalTimespan.Seconds);
        Console.ReadLine();
    }
 
}

// create object and edit
using System;
class Student
{
    private string myName = "N/A";
    private int myAge = 0;
    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }
    public int Age
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }
 
    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
 
    public static void Main()
    {
        Student Student = new Student();
        Console.WriteLine("Student details - {0}", Student);
        Student.Name = "BOB";
        Student.Age = 99;
        Console.WriteLine("Student details - {0}", Student);
        Student.Age += 1;
        Console.WriteLine("Student details - {0}", Student);
        Console.ReadLine();
    }
}