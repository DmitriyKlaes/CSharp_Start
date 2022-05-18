// Вид 1
void Method()
{
    System.Console.WriteLine("Автор Димуля");
}
Method();

// Вид2
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
    System.Console.WriteLine(msg);
}
Method2(msg: "Текст", count: 4);
Method2(count: 4, msg: "Новый текст");

// Вид3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// Вид4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // или "" вместо String.Empty

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
System.Console.WriteLine(res);

// Вид4(1)

string Method4(int count, string text)
{
    string result = String.Empty; // или "" вместо String.Empty
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
System.Console.WriteLine(res);