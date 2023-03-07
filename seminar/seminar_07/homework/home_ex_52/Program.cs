// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

using static Library.Shared;

int[,] matrix = new int[4,3];
Fill2IntArray(matrix);
Print2IntArray(matrix);
double average = 0;
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        average += matrix[j,i];
    }
    Console.Write(Math.Round(average/(matrix.GetLength(0)), 2) + "|");
    average =0;
}


