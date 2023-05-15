# Information notes about C sharp

- [Information notes about C sharp](#information-notes-about-c-sharp)
  - [General](#general)
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

## General

- One main method only
-

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