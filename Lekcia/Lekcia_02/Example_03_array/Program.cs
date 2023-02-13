int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] massif = { 1, 2, 3, 4, 51, 6, 7, 8, 9 };

int result = Max(Max(massif[0], massif[1], massif[2]),
                Max(massif[3], massif[4], massif[5]),
                Max(massif[6], massif[7], massif[8]));
Console.WriteLine(result);
