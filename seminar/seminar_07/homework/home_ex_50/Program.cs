// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static Library.Shared;

int[,] matrix = new int[4, 5];
Fill2IntArray(matrix);
Print2IntArray(matrix);
int line = InputIntUser("index line: ");
int colum = InputIntUser("index column: ");
if (line > matrix.GetLength(0) | colum > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine("значение элемента:  "+matrix[line, colum]);
}
