// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
using static Library.Shared;
//cоздать массив\ запросить размер массива
int size = InputIntUser("vveditr razmer massiva: ");
int[] arr = CreatIntArray(size);
// заполнить рандомно
FillArray(arr, 100, 1000);
Console.WriteLine(ArrayJoinToString(arr));
// счетчик четных чисел
int EvenNumbCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int evenNumb = EvenNumbCounter(arr);

// рачпечатать результат
Console.WriteLine("Четных чисел в массиве: "+evenNumb);



