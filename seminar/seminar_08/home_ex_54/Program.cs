// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static Library.Shared;


Console.Clear();
int line = InputIntUser("количество строк: ");
int column = InputIntUser("количество столб: ");
int[,] matrix = new int[line, column];
Fill2IntArray(matrix);
Print2IntArray(matrix);
Console.WriteLine();
SelectionSort(matrix);
Print2IntArray(matrix);



