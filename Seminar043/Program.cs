// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] FillArray (int size)
    {
        int[] massive = new int[size];
        for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = new Random().Next(-9,10);
            }
        return massive;
    }

 Console.WriteLine("Введите длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool check = false;
int count =0;

int[] array = FillArray(number);

Console.WriteLine(String.Join(",", array));

for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNumber)
            {
                check = true;
                count++; // правильнее истопользовать break;
            }
    }

if (check == true)
    {
        Console.WriteLine($"Число присутствует в массиве, встречается {count} раз.");
    }
else
    {
        Console.WriteLine($"Число не встретилось");
    }