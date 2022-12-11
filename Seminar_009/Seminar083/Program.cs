// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int sum = 0;
// int n = Convert.ToInt32(Console.ReadLine());
// Sum(n, sum);
// void Sum(int n, int sum)
//     {
//         if( n ==0)
//             {
//                 Console.Write(sum);
//                 return;
//             }
//         sum+=n%10;
//         Sum(n/10, sum);

//     }


int Rec(int n)
{

if (n == 0)
{
return 0;
}
return n % 10 + Rec(n / 10);

}
Console.Write("Введите первое значение: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(Rec(N));