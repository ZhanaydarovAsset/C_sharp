// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using static Library.Shared;
Console.Clear();
int[] SummaLine(int[,] matr)
{
    int[] summLine = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            summLine[i] += matr[i, j];
        }
    }
    return summLine;
}

int size = InputIntUser("enter matrix size: ");
int[,] matrix = new int[size, size];
Fill2IntArray(matrix);
Print2IntArray(matrix);

int[] summ = SummaLine(matrix);
Console.WriteLine(ArrayJoinToString(summ));
int minOfSumm = summ.Min();
int indexMin = Array.IndexOf(summ, minOfSumm);
Console.WriteLine("строкa с наименьшей суммой элементов: "+ indexMin+1);

