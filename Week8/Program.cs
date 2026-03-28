using Variant2;

Point p1 = new Point { X = 5, Y = 7 };
Point p2 = p1;

p2.X = 67;

p1.Print();
p2.Print();

Console.WriteLine();

PointRef r1 = new PointRef { X = 3, Y = 4 };
PointRef r2 = r1;

r2.X = 52;

r1.Print();
r2.Print();

Console.WriteLine();

BoxingTester.Test();