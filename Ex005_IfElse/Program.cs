Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "катя")
{
    Console.WriteLine("Йоу! Йоу! Йоу! Это же КАТЯ!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}