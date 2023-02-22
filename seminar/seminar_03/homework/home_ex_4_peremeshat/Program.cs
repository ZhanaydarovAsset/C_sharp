//Реализовать перемешивание массива

int Promt(string message)
{
    Console.WriteLine(message);
    string valve = Console.ReadLine();
    int result = Convert.ToInt32(valve);
    return result;
}

void FillMassif(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintMassif(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void MixArray(int[] arr)
{
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < size - 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[i + 2];
            arr[i + 2] = temp;
        }
    }
}

int size = Promt("Введите размер массива: ");
int[] array = new int[size];

FillMassif(array);
PrintMassif(array);
MixArray(array);
Console.WriteLine();
PrintMassif(array);
