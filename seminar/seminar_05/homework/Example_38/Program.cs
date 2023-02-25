// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using static Library.Shared;

int size = InputIntUser("Введите размер массива: ");

double[] massiv = CreatDoubleArray(size);

FillDoubleArray(massiv, 10, 2);

Console.WriteLine(DoubleArrayJoinToString(massiv));

Console.WriteLine("Сумма мин и макс =" + (massiv.Max() +  massiv.Min()));
