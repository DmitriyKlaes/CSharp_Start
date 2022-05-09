//Тренировка

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
Console.WriteLine("Выбрать случайные 9 чисел от 1 до 100 (введите Y или N)?:");
string choice = Console.ReadLine()!;
int[] array = new int[9];
while (choice.ToLower() == "y")
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 100);
    }
    break;
}
while (choice.ToLower() == "n")
{
    Console.WriteLine("Введите 9 случайных чисел через (Пробел):");
    string[] arrayNumber = (Console.ReadLine()!.Split(' '));
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        array[i] = int.Parse(arrayNumber[i]);
    }
    break;
}
int max = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));
    string str = string.Join(", ", array);
    Console.WriteLine($"Максимальным из чисел ({str}) является {max}");