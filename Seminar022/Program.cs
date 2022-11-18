// AB = √(xb - xa)2 + (yb - ya)2
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
// Math.Sqrt(object)
// Math.Pow(args,2)
// Math.Round(a, 2)

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double lenghtLine;

lenghtLine = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
Console.WriteLine(lenghtLine);



