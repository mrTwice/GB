// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


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

string massive="";

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                massive = massive + array[i,j];
            }
    }

Console.WriteLine(massive);




for (int size = 0; size < massive.Length; size++)
    {
        int someString = 0;
        int count = 0;
        someString = Convert.ToInt32(massive[size]);
        Console.WriteLine(someString);
        // for (int i = 0; i < m; i++)
        //     {
        //         for (int j = 0; j < n; j++)
        //             {
        //                 if ( someString == array[i,j])
        //                     {
        //                         count++;
        //                     }
        //             }
        //     }
        // Console.WriteLine($"{massive[size]} встречается {count}");
    }

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for(int k = 0; k < 10; k++)
// {
//     int count = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] == k)
//             {
//                 count++;
//             }
//         }
//     }
//     if(count != 0) Console.WriteLine($"Кол-во повторений для {k} = {count}");
// }