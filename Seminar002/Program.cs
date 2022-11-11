Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberВ = Convert.ToInt32(Console.ReadLine());

if(numberA*numberA == numberВ)
    {
        Console.WriteLine("Квадрат первого числа равен второму");
    }
else
    {
    Console.WriteLine("Квадрат первого числа не равен втрому");
    }