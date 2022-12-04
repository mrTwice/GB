// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void BinView(int number)
{
    if (number == 0)
    {
        return;
    }
    BinView(number/2);
    Console.Write(number%2);
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

BinView(A);


