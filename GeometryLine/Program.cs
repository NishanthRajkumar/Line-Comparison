using GeometryLine;

Console.Title = "Line Comparison App";
Console.WriteLine("----------------------Geometry Line Comparison App----------------------");
Line line1 = new Line();
Line Line2 = new Line();
Console.WriteLine("Enter line 1 details: ");
line1.GetPointsFromUser();
Console.WriteLine("Enter line 2 details: ");
Line2.GetPointsFromUser();
Console.WriteLine("\nLine 1: ");
line1.Describe();
Console.WriteLine("Line 2: ");
Line2.Describe();
line1.Compare(Line2);
Console.ReadKey();