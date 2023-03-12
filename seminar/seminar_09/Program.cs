
// задаем двумерный 
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr, int count)
{
    int x = 0; int y = 0; for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите координаты магазина: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine()); matr[x, y] = 1;
    }
}
int[,] matrix = new int[10, 10];
PrintArray(matrix);
Console.WriteLine("Введите количество магазинов: ");
int stores = Convert.ToInt32(Console.ReadLine());
FillArray(matrix, stores);
PrintArray(matrix);

void LenPoint(int[,] matr)
{
    int n = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int l = 0; l < matr.GetLength(1); l++)
                {
                    if (matr[i, j] == 1 && matr[k, l] == 1)
                    {
                        double Len = Math.Sqrt(Math.Pow(k - i, 2) + Math.Pow(l - j, 2));
                        Console.WriteLine($"для магазина {n}");
                        Console.WriteLine(Len);
                    }
                        n++;
                }
            }
        }

    }
}

LenPoint(matrix);
