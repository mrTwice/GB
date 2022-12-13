// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] array = FillArray(number);

 Console.WriteLine(String.Join(",", array));

for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
    }

 Console.WriteLine(String.Join(",", array));