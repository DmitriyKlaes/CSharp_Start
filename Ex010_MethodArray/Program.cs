int[] array = { 11, 21, 31, 19, 15, 61, 17, 18, 19 };
int n = array.Length;
int find = 19;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break; //стоп слово, остановит на первом найденном
    }
    index++;
}