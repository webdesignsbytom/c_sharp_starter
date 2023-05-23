# Data

## Table of contents

- [Data](#data)
  - [Table of contents](#table-of-contents)
  - [Keywords](#keywords)
    - [Abstract](#abstract)

## Keywords

### Abstract

- `abstract` The abstract modifer indicitates that the thing being modified has a missing or imcomplete implementation. Abstract can be used with classes, methods, properties, indexers and envts. Used for a base class which will not be instanciated on its own.

- Abstract classes have the following features:
  1. Cannot be instantiated `instantiation describes the processes of creating a new object for a class using a new keyword`
  2. May not contain abstract methods and accessors.
  3. May not be modified with the `sealed` modifier because they have opposite meanings. Sealed prevents a class being inherited by abstract. and abstract requires a class to be inherited.
  4. A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

```cs
abstract class Shape
{
    public abstract int GetArea();
}

class Square : Shape
{
    private int _side;

    public Square(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;

    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
    }
}
// Output: Area of the square = 144
```

- `
