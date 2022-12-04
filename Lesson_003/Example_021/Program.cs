// вид 1

void Method1()
{
    Console.WriteLine("Author");
}

Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text mesg");
Method2(msg: "Text mesg");

void Method21(string msg, int count);
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(mesg:"Text", count: 4); // именованные аргументы можно писать не по порядку

// Вид 3
int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4

// 
int Method4(int count, string c)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
        {
            result = result + c;
        }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);