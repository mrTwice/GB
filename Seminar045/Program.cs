﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




// int[] FillArray(int size)
// {
    
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));

// int newLength = array.Length % 2 + array.Length/2;
// int[] newArray = new int[newLength];
// for(int i = 0; i < array.Length/2; i++)
// {
//     newArray[i] = array[i] * array[array.Length-1-i];
// }
// if (array.Length % 2 > 0)
// {
//     newArray[newArray.Length-1] = array[array.Length/2];
// }
// Console.WriteLine(string.Join(", ", newArray));






//

int[] FillArray (int size)
    {
        int[] massive = new int[size];
        for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = new Random().Next(0,10);
            }
        return massive;
    }

 Console.WriteLine("Введите длинну массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(arrayLength);
int[] newMassive = new int[array.Length/2];

 Console.WriteLine(String.Join(",", array));
  Console.WriteLine();

if(array.Length%2 == 0) // среднего элемента нет
    {

        for (int i =0; i < array.Length/2; i++)
            {
               newMassive[i] = array[i] * array[array.Length-1-i];
            }
    }
else // есть средний элемент
    {
        for (int i =0; i < (array.Length/2+1); i++)
            {
               newMassive[i] = array[i] * array[array.Length-1-i];
               newMassive[array.Length/2+1] = array[array.Length/2];
            }
    }

Console.WriteLine(String.Join(",", newMassive));