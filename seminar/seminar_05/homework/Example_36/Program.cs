// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using static Library.Shared;

//cоздать массив\ запросить размер массива
int size = InputIntUser("vveditr razmer massiva: ");
int[] arr = CreatArray(size);
// заполнить рандомно
FillArray(arr, 1, 100);
Console.WriteLine(ArrayJoinToString(arr));
int summa = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    summa += arr[i];
}
Console.WriteLine("сумму элементов, стоящих на нечётных позициях: "+summa);