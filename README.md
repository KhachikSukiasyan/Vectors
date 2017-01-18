# Vectors
### Used
## Visual Studio 2015 Community Edition and Microsoft .NET Framework 4.6 

This is an example of operator overloading in C#.Example represents vectors and basic operations applyed on them.Project includes
operations of adding,subtracting,scalar multiplication,multiplication by number.

example:

```C#
Vector a = new Vector(1, 2);
Vector b = new Vector(2, 1);

Vector c = a + b;
c.print();

Vector d = c - 7 * a;
 d.print();

Console.WriteLine(a * c);
```
