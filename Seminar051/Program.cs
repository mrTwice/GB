
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


void FillArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,100);
            }
    }
void ReArray (int[] array)
    {
        for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i -1];
                array[array.Length-i-1] = temp;
            }
    }
void PrintArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"  {array[i]}");
            }
    }


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

 FillArray(array);
PrintArray(array);
Console.WriteLine();
ReArray(array);
PrintArray(array);
