// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int CountNum(int number)

{
    int index = 0;
    while ( number != 0)
        {
            number/=10;
            index++;
        }
    return index;
}

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int count  = CountNum(num);
Console.WriteLine("Количество цифер в числе: "+ count);



// Console.WriteLine("Введите число");
// string? A = Convert.ToString(Console.ReadLine());
// if (int.TryParse(A, out int num))
//     Console.Write("Количество цифр в числе: " + A.Length);
// else
//     Console.Write("В строке не только цифры, напишите число");