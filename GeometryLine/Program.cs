﻿using GeometryLine;

Console.Title = "Line Comparison App";
Console.WriteLine("----------------------Geometry Line Comparison App----------------------");

// Create 2 Line objects
Line line1 = new();
Line line2 = new();

// Input the points for each line
Console.WriteLine("Enter line 1 details: ");
line1.GetPointsFromUser();
Console.WriteLine("Enter line 2 details: ");
line2.GetPointsFromUser();

// Display the info of each line
Console.WriteLine("\nLine 1: ");
line1.Describe();
Console.WriteLine("Line 2: ");
line2.Describe();

// Compare the line lengths and display result
Console.WriteLine("Comparing the 2 lines");
int result = line1.Compare(line2);
switch (result)
{
    case 0:
        Console.WriteLine("The lines are equal in length");
        break;
    case 1:
        Console.WriteLine("Line 1 length is lesser than line 2");
        break;
    case 2:
        Console.WriteLine("Line 1 length is greater than line 2");
        break;
    default:
        Console.WriteLine("Error!!");
        break;
}

// Checks if 2 lines are equal
Console.Write("\nIs Line 1 equal to Line 2? " + line1.Equals(line2));

Console.ReadKey();