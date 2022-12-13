// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

Console.Write("Введите размерность массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность массива m x n");
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                array[i,j] = new Random().Next(0,10);
                Console.Write(String.Format("{0,3}", array[i,j]));
            }
        Console.WriteLine();
    }

Console.WriteLine();
int[,] arrayRotate = new int[n,m];

for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
            {
                arrayRotate[j,i] = array[i,j];
                Console.Write(String.Format("{0,3}", arrayRotate[j,i]));
            }
        Console.WriteLine();
    }