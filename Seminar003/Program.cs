Console.Write("Введите номер дня недели:");
int today = Convert.ToInt32(Console.ReadLine());

if(today<1) Console.WriteLine("Номер дня недели не может быть равен нулю");
if(today>7) Console.WriteLine("Дней в неделе всего семь");
if(today==1) Console.WriteLine("Сегодня понедельник");


if(today==2) Console.WriteLine("Сегодня вторник");
if(today==3) Console.WriteLine("Сегодня среда");
if(today==4) Console.WriteLine("Сегодня четверг");
if(today==5) Console.WriteLine("Сегодня пятница");
if(today==6) Console.WriteLine("Сегодня суббора");
if(today==7) Console.WriteLine("Сегодня воскресение");