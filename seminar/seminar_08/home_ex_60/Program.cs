// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
using static Library.Shared;

void Print3dArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} {(i, j, k)} ");

            }
            Console.WriteLine();
        }
    }
}

int FindOf(int[,,] matr, int element)
{
    int x = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == element) { x = element; }

            }
        }

    }
    return x;
}

int[,,] matrix3d = new int[3, 3, 3];
for (int i = 0; i < matrix3d.GetLength(0); i++)
{
    for (int j = 0; j < matrix3d.GetLength(1); j++)
    {
        for (int k = 0; k < matrix3d.GetLength(2); k++)
        {
            matrix3d[i, j, k] = new Random().Next(10, 100);
            while (matrix3d[i, j, k] != FindOf(matrix3d, matrix3d[i, j, k]))
            {
                matrix3d[i, j, k] = new Random().Next(10, 100);

            }
        }
    }
}


Print3dArray(matrix3d);

