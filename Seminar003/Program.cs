int mon = 1, tu = 2, wen = 3, th = 4, fri = 5, sun = 6, sat = 7;
Console.Write("Введите номер дня недели:");
int today = Convert.ToInt32(Console.ReadLine());

if(today==mon) Console.WriteLine("Сегдня понедельник");
if(today==tu) Console.WriteLine("Сегдня вторник");
if(today==wen) Console.WriteLine("Сегдня среда");
if(today==th) Console.WriteLine("Сегдня четверг");
if(today==fri) Console.WriteLine("Сегдня пятница");
if(today==sun) Console.WriteLine("Сегдня суббора");
if(today==sat) Console.WriteLine("Сегдня воскресение");