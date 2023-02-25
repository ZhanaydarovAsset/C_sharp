// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

int Promt(string message)
{
    Console.WriteLine(message);
    string valve = Console.ReadLine()!;
    int result = Convert.ToInt32(valve);
    return result;
}

void FillMassif(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

int sizeArray = Promt("Введите размер массива");
Console.WriteLine();

int[] array = new int[sizeArray];

FillMassif(array);

string showArray = string.Join(" ", array);
Console.WriteLine($"massif [{showArray}]");
