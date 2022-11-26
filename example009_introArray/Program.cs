int Max(int arg1, int arg2, int arg3)
{
    int maximum = arg1;
    if (arg2 > maximum) maximum = arg2;
    if (arg3 > maximum) maximum = arg3;
    return maximum;
}

int[] array = { 11, 32, 43, 542, 65, 76, 43, 123, 54 };

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);