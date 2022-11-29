// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A+B > C & B+C > A & A+C >B) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");