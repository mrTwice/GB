//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,100);
            }
    }

void PrintArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"  {array[i]}");
            }
    }

void CopyArray (int[] array, int[] copyarray)
    {
        for (int i = 0; i < array.Length; i++)
            {
                copyarray[i] = array[i];
            }
    }
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());   
int[] firstArray = new int[N];
int[] secondArray = new int[N];

FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();
CopyArray(firstArray,secondArray);
PrintArray(secondArray);
