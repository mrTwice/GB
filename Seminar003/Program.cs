Console.Write("Введите номер дня недели:");
int today = Convert.ToInt32(Console.ReadLine());

if (today < 1) {Console.WriteLine("Номер дня недели не может быть равен нулю");}
else if (today > 7) {Console.WriteLine("Дней в неделе всего семь");}
else if (today == 1) {Console.WriteLine("Сегодня понедельник");}
else if (today == 2) {Console.WriteLine("Сегодня вторник");}
else if (today == 3) {Console.WriteLine("Сегодня среда");}
else if (today == 4) {Console.WriteLine("Сегодня четверг");}
else if (today == 5) {Console.WriteLine("Сегодня пятница");}
else if (today == 6) {Console.WriteLine("Сегодня суббора");}
else if (today == 7) {Console.WriteLine("Сегодня воскресение");}

/*string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum > day.Length || dayNum <= 0)
{
    Console.WriteLine("Дней всего 7!");
}
Console.WriteLine(day[dayNum - 1]);

Console.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
}
*/
