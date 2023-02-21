int[] massif = { 11, 2, 8, 6, 1, 2, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(massif);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPos = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

SelectionSort(massif);
PrintArray(massif);