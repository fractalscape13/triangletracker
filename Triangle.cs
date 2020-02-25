using System;
using System.Collections.Generic;

public class Triangle
{
  static void Main()
  {
    Console.WriteLine("Let's see what's up with your so-called triangle...");
    Console.WriteLine("Enter the length of side 1 (numbers only plz)");
    int side1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the length of side 2 (numbers only plz)");
    int side2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the length of side 3 (numbers only plzzz)");
    int side3 = int.Parse(Console.ReadLine());
    if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
    {
    Console.WriteLine("This ain't no triangle");
    }
    else if (side1 == side2 && side1 == side3) 
    {
      Console.WriteLine("This is, without a doubt, an EQUILATERAL triangle");
    }
    else if (side1 == side2 || side2 == side3 || side3 == side1)
    {
      Console.WriteLine("This here is what we call an ISOSCELES triangle");
    }
    else if (side1 != side2 && side2 != side3 && side1 != side3)
    {
      Console.WriteLine("This is the mythical SCALENE triangle");
    }
  }
}