// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArr(int[] randomToArray)
{
    for (int i = 0; i < randomToArray.Length; i++)
        {
            randomToArray[i] = new Random().Next(0, 2);
        }
}

void PrintArr(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i]);
    }
}

int[] array = new int[8];

FillArr(array);
PrintArr(array);

//Console.Write('[' + string.Join(", ", arr) + ']');