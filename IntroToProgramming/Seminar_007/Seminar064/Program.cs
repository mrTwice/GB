
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.WriteLine("Введите размерность двемерного массива m x n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
            {
                matrix[i,j] = new Random().Next(0,11);
                Console.Write(matrix[i,j] + " ");
            }
        Console.WriteLine();
    }

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
int mainSum = 0;
for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
            {
                if (i == j) mainSum = mainSum + matrix[i,j];
            }
    }
Console.WriteLine(mainSum);