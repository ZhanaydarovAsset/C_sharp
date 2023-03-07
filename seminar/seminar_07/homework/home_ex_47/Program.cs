// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using static Library.Shared;


int line = InputIntUser("количество строк: ");
int colum = InputIntUser("количество столбцов: ");
double[,] matrix = new double[line, colum];
Fill2Array(matrix, 10, 2);
Print2Array(matrix);
