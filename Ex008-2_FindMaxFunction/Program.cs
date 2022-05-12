

Console.WriteLine("Выбрать случайные числа от 1 до 99 (введите Y или N)?:");
string choice = Console.ReadLine()!;
if (choice.ToLower() == "y")
{
    Console.WriteLine("Введите размер массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    //while (choice.ToLower() == "y")
    //{
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 100);
        }
        //break;
    //}
    //int max = array[0];
    int index = 1;
    int max = array[0];
    while (index <= length)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    string arraystring = string.Join(", ", array);
    Console.WriteLine($"Максимальным из чисел ({arraystring}) является {max}");
}
if (choice.ToLower() == "n")
{
    int[] array = new int[2];
    Console.WriteLine("Введите N-е количество чисел");
    Console.WriteLine("Чтобы закончить ввод, введите пробел");
    try
    {
        for (int i = 0; i < array.Length; i++)
        {
            Array.Resize (ref array, array.Length + 1);
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
        }
    }
    catch
    {
        Array.Resize (ref array, array.Length - 3);
    }
    int max = array[0];
    int index = 1;
    if (max < array[index])
    {
        max = array[index];
        index++;
    }
    else
    {
        index++;
    }
    string arraystring = string.Join(", ", array);
    Console.WriteLine($"Максимальным из чисел ({arraystring}) является {max}");
}