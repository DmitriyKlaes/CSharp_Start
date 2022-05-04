int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int a2 = 21;
int a3 = 39;
int b1 = 14;
int b2 = 28;
int b3 = 44;
int c1 = 16;
int c2 = 21;
int c3 = 35;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
