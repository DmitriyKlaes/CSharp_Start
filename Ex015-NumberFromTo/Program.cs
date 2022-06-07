/*
Собираем строку от а до б.
*/

string NumbersRec(int a, int b)
{
    //if (a <= b)
    //{
    //    return NumbersRec(a + 1, b) + $"{a} ";
    //}
    if (a <= b)
    {
        return $"{a} " + NumbersRec(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersRec(1, 10));