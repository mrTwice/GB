﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
            {
                sum = sum+i;
            }
        return sum;
    }


Console.WriteLine("Введите число А: ");

int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);
Console.WriteLine("Сумма чисел = "+ sum);