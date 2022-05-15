List<int> array = new List<int>();
try
{
    for (int i = 0; i < array.Count; i++)
    {
        System.Console.WriteLine("123");
        array.Add(Convert.ToInt32(Console.ReadLine()));
    }
}
catch
{

}
string arraystring = string.Join(", ", array);
Console.WriteLine(arraystring);

/*
int max = 0;
int index = 1;
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine())!;
Console.WriteLine("Выбрать случайные числа от 1 до 99 (введите Y или N)?:");
string choice = Console.ReadLine()!;
int [] array = new int [length];
if (choice.ToLower() == "y")
{
    for (int i = 0; i < length; i++) 
    {
        array[i] = new Random().Next(1, 100);
    }
    for (max = array[0]; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }
}
if (choice.ToLower() == "n")
{
    for (int i = 0; i < length; i++) 
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    for (max = array[0]; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }
}
string arraystring = string.Join(", ", array);
Console.WriteLine($"Максимальным из чисел ({arraystring}) является {max}");
*/


//Console.WriteLine("Выбрать случайные числа от 1 до 99 (введите Y или N)?:");
//string choice = Console.ReadLine()!;
/*
class Program
{
    static void Main(string[] args)
    {
        int length;
        Console.WriteLine("Введите размер массива:");
        length = int.Parse(Console.ReadLine())!;
        int [] array = new int [length];
        for (int i = 0; i < length; i++) 
        {
            array[i] = new Random().Next(1, 100);
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadKey();
    }
}*/


/*Console.WriteLine("Выбрать случайные числа от 1 до 99 (введите Y или N)?:");
//string choice = Console.ReadLine()!;
class Program
{
static void Main(string[] args)
{
//if (choice.ToLower() == "y")
//{
    Console.WriteLine("Введите размер массива:");
    int length;
    int max;
    int index = 1;
    length = int.Parse(Console.ReadLine());
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1, 100);
    }
    /*
    Console.WriteLine("Введите размер массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 100);
        }
    
    for (max = array[0]; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }
    string arraystring = string.Join(", ", array);
    Console.WriteLine($"Максимальным из чисел ({arraystring}) является {max}");
    Console.ReadKey();
    
}
}

if (choice.ToLower() == "n")
{
    Console.WriteLine("Введите N-е количество чисел");
    Console.WriteLine("Чтобы закончить ввод, введите пробел");
    int n;
    n = int.Parse(Console.ReadLine());
    int [] a = new int [n];
    for (int i = 0; i < n; i++) 
    {
        a[i] = int.Parse(Console.ReadLine());
    }
    int[] array = new int[2];
    Console.WriteLine("Введите N-е количество чисел");
    Console.WriteLine("Чтобы закончить ввод, введите пробел");
    /*try
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
    for (int i = 0; i < array.Length; i++)
        {
            try 
            {
                Array.Resize (ref array, array.Length + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            catch
            {
            break;
            }
        }

    for (max = array[0]; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }
    string arraystring = string.Join(", ", array);
    Console.WriteLine($"Максимальным из чисел ({arraystring}) является {max}");
}
*/
