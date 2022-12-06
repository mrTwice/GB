// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
int toReplaceRows = 0;

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                if (i == 0)
                    {
                        toReplaceRows = array[i,j];
                        array[i,j] = array[array.GetLength(0)-1,j];
                        array[array.GetLength(0)-1,j] = toReplaceRows;

                    }
                Console.Write(String.Format("{0,3}", array[i,j]));
            }
        Console.WriteLine();
    }

 Console.WriteLine();


//  int[,] FillMatrix(int rows, int columns)
// {
//     int[,] matrix = new int [rows, columns];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for(int j = 0; j < matrix.GetLength(1); j++)
// {
//     int temp = matrix[0, j];
//     matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
//     matrix[matrix.GetLength(0)-1,j] = temp;
// }

// PrintMatrix(matrix);