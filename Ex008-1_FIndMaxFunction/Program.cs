//Тренировка

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Выбрать случайные числа от 1 до 100 (введите Y или N)?:");
string choice = Console.ReadLine();
int[] array = new int[9];
if (choice == "y")
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("что то не так");
        Random rand = new Random();
        array[i] = rand.Next(1, 100);
    }
}
/*if (choice.ToLower() == "n")
{
    Console.WriteLine("Введите 9 случайных чисел через (Пробел):");
}*/
else
{
    System.Console.WriteLine("Неверный выбор!");
}
string[] arrayNumber = (Console.ReadLine().Split(' '));
for (int i = 0; i < arrayNumber.Length; i++)
{
    array[i] = int.Parse(arrayNumber[i]);
}
int max = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));
string str = string.Join(", ", arrayNumber);
Console.WriteLine($"Максимальным из чисел ({str}) является {max}");


/*
int[] array = new int[9];
for (int i = 0; i < array.Length; i++)
{
    Random rand = new Random();
    array[i] = rand.Next(1, 100);
}
string str = string.Join(", ", array);
System.Console.WriteLine(str);
*/