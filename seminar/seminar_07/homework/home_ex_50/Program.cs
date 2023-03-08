// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static Library.Shared;

int[,] matrix = new int[4, 5];
Fill2IntArray(matrix);
Print2IntArray(matrix);
int line = InputIntUser("index line: ");
int colum = InputIntUser("index column: ");
if (line+1 <= matrix.GetLength(0) || colum+1 <= matrix.GetLength(1))
{
    Console.WriteLine("значение элемента:  "+matrix[line, colum]);
}
else
{
    Console.WriteLine("такого элемента нет");
}

