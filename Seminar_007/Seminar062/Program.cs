// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.



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

for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
            {
                if (i%2 == 0 & j%2 == 0)
                    {
                        matrix[i,j] = matrix[i,j] * matrix[i,j];
                    }
                Console.Write(matrix[i,j] + " ");
            }
        Console.WriteLine();
    }