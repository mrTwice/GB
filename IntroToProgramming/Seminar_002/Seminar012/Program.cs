// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int N = new Random().Next(100, 1000);


int firstNumber = N/100;
int secondNumber = N%10;

Console.Write($"{N} - >");
Console.WriteLine($"{firstNumber}{secondNumber}");