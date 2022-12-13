// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



Console.WriteLine("Введите значения N и M");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());

void Chisla(int n, int m)
{
Console.Write(n + " ");
if (n == m) return;
Chisla(n + 1, m);
}
if (M>N) Chisla(N, M);
else Chisla(M, N);


// void Rec(int n, int m)
// {
// if (m > n)
// {
// if (n == m)
// {
// return;
// }
// Rec(n, m - 1);
// Console.Write($"{m} ");
// }
// else if (m<n)
// {
// if (m == n) return;
// Rec(m, n - 1);
// Console.Write($"{n} ");
// }
// else Console.Write($"{m} ");
// }
// Console.Write("Введите первое значение: ");
// int N = int.Parse(Console.ReadLine());
// Console.Write("Введите второй значение: ");
// int M = int.Parse(Console.ReadLine());
// Rec(N, M);