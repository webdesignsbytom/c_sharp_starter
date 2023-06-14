# Information notes about C sharp

- [Information notes about C sharp](#information-notes-about-c-sharp)
  - [General](#general)
  - [Static](#static)
  - [Errors](#errors)
  - [Syntax Rules](#syntax-rules)
  - [Types of Access Modifiers](#types-of-access-modifiers)
  - [Attributes and properties](#attributes-and-properties)
  - [IS operator](#is-operator)
  - [AS operator](#as-operator)
  - [Operators](#operators)
  - [Data types](#data-types)
  - [Functions](#functions)
  - [Interfaces](#interfaces)
  - [ML.Net](#mlnet)
  - [Generics](#generics)
  - [Interfaces](#interfaces-1)
  - [2d](#2d)
  - [Threading](#threading)
    - [Foreground Threads](#foreground-threads)
    - [Background Threads](#background-threads)
    - [Thread Priority](#thread-priority)
    - [Thread Pooling](#thread-pooling)
    - [Blocking](#blocking)
    - [Parallel Programming](#parallel-programming)
  - [LINQ](#linq)

## General

- One main method only


## Static

A static field is a unchaging collection of data. i.e starting number of cars in a race

## Errors

Types of errors include:
Syntax errors - you types something wrong
Logic errors - code does something unexpected
runtime errors - happens when the program is running

## Syntax Rules

All codes look differently from each other because they are structured with syntax rules.

- Case sensitivey (c and C are different)
- Start and end of function do not have ;
- Start and end with curly braces
- Namespaces are used to keep code blocks separated and import each other
- A class goes inside a namespace

## Types of Access Modifiers

- Public - means other code can call and modify
- Private - to protect code so only the class its in can access it.
- internal - default public
- protected

## Attributes and properties

- attributes are inside []

## IS operator

- Used to check the value of a certaqin tpye.
- Avoids 'InvalidCastException'
- Lets us know if we can cast a certain type.

## AS operator

- Sometime you want to cast a variable of one type to another
- the AS operator helps us to avoid an invalid cast exception
- If the cast is valid, the AS operator the return the object cast tot the new tpye
- If the cast is invalid then the AS operator will return null

```cs
        {
            string s1 = "abc";
            object obj1 = s1;
            string s2 = obj1 as string;
            Console.WriteLine("s2", s2);
            Console.ReadLine();
        }
```

## Operators

Null-coalescing operator
If the left side is null then the right side will be used

```cs
    var = left operand ?? right operand
```

sizeof() operator

```cs
    Console.WriteLine(sizeof(int));
```

typeof() operator

```cs
    Console.WriteLine(typeof(var));
```

overloading
ex. 2 + 2 = 4
Operator overloading lets you add multiple conditons togeth

- Function must be `public static`
- `Box operator +`

## Data types

Built In Data Types in C sharp

- Int (System.Int32), float (System.single), string (System.String), characters (System.Char), boolean (System.Boolean).

Numbers

- Int - ++Value or Value++
- Float `var = 1.1f`
- Get remainders using modulus (10%3)

## Functions

Constructors

- if you dont create on c sharp will do it under the hood

```cs
    public class Example
    {
        int age;
        // Contructor
        public Example(int num) {
            age = num;
        }

        public static void Main(string[] args)
        {
            Example test = new Example(5)
            System.Diagnostics.Debug.WriteLine(test.age)
        }
    }
```

Finalizers

- A special type of function that is called when an object is created.
- No access modifiers
- Only the garbage collectors can envoke when destroying the object.

Properties

- get and set variables

```cs
    public class Example
    {
        public string Name { get; set;}

        public static void Main(string[] args)
        {

        }
    }
```

```cs
    public class Example
    {
        private string Name;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                name = value
            }
        }

        public static void Main(string[] args)
        {
            Example test = new Example();
            test.Name = "harry kin";
            System.Diagnostics.Debug.WriteLine(Example.Name)
        }
    }
```

Attributes

- used to add metadata
- methods and properties
- reflection to view data
- [attribute]

## Interfaces

// interfaces decouple classes and give us a range of reusable functionality, its a work around to multiple inheritance
// Cannot contain fields or variables
// You must impletment all the code
// each class can have only one base class - but can implement its own interface.

```cs
namespace LessonOne
{
    interface IExample
    {
        void Example();

        int Example2();

        string Example3(string string1, string string2);
    }
}


 internal class Program : IExample, SecondInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.ReadLine();
        }

        public void Example()
        {
            Console.WriteLine("Hello");
        }
```

## ML.Net

A free open source cross-platform
ML.Net is used in machine learning for C# F#
Predict models, classify image, AI

## Generics

- pass any data type using generics
- <T> T makes it generic
- reusable .net
- List<T> is placeholder for type

```cs
class Program<T>
{
    void PrintMessage(T message){}
}
```

## Interfaces

## 2d

- float[,] heightAll = terData.GetHeights(0, 0, allWidth, allHeight); [,] means its a 2D array or game grid
- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays?redirectedfrom=MSDN

## Threading 

- What is Threading
- using System.Threading;

An independent path for code to be executed on
Multithreading uses many threads simultaneously (parallel execution of code)
The MAIN() method is the default thread
Each thread has its own call stack
When you call .start() the thread will be started running by the OS
Share heap memory with threads
You can only start a thread once (basically)
you can only change the name at the start and once

INDEPENDANT EXCUTION PATH OF CODE

1. Create a static function that can be called from the main method 
2. ```Thread t = new Thread(ExampleFunction)```

### Foreground Threads

By defualt all threads are foreground.
If the foreground threads end while background threads are running they will be terminated

### Background Threads

Check by using .isBackground = true - properties

### Thread Priority

Its an ENUM type
Several settingd that tell them when to run

### Thread Pooling 

- ```ThreadPool.QueueUserWorkItem(Example1);```

Reusable threads that can be called when needed to save space
use the ThreadPool class
Once itsa used it is returned to the pool

### Blocking

Blocking is used to run one thread at a time or in a order
Prevent threads for messing up shared data.
If blocked it does not use cpu resources
- use Thread.Sleep(1000) to pause a thread
- use Thread.Join() to get order
- use lock(name) to prevent changes until a process has finished

### Parallel Programming

An advanced threading process that uses multiple cores of a machine.

## LINQ

````js
List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", Age = 30 },
                new Person() { Name = "Sarch", Age = 25 },
                new Person() { Name = "James", Age = 32 },
                new Person() { Name = "Joseph", Age = 24 },
            };

            int oldestPersonAge = people.Select(x => x.Age).Max();
            Console.WriteLine("Oldest: " + oldestPersonAge);
            ```
````
