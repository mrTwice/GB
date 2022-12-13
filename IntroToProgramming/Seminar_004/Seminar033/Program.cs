﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



int Factorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(A);
Console.WriteLine("Сумма чисел равна " + factorial);