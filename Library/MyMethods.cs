
namespace Library;
public class Shared
{
    //Ввод числа с консоли
    public static int InputIntUser(string text)
    {
        Console.WriteLine(text);
        int result = Convert.ToInt32(Console.ReadLine()!);
        return result;
    }

    public static double InputDoubleUser(string text)
    {
        Console.WriteLine(text);
        double result = Convert.ToDouble(Console.ReadLine()!);
        return result;
    }

    //создал массив
    public static int[] CreatIntArray(int size)
    {
        return new int[size];
    }

    public static double[] CreatDoubleArray(int size)
    {
        return new double[size];
    }

    //заполнить массив рандомно
    public static void FillArray(int[] array, int minRandom, int maxRandom)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minRandom, maxRandom);
        }
    }

    public static void FillDoubleArray(double[] array, int factor, int fraction)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round( new Random().NextDouble() * factor, fraction);
        }
    }


    //перевести массив в строку для распечатки
    public static string ArrayJoinToString(int[] array)
    {
        return $"[{String.Join(' ', array)}]";
    }

    public static string DoubleArrayJoinToString(double[] array)
    {
        return $"[{String.Join(' ', array)}]";
    }



    public static void Print2Array(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Fill2Array(double[,] matr, int factor, int fraction)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = Math.Round( new Random().NextDouble() * factor, fraction);
            }
        }
    }

    public static void Print2IntArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Fill2IntArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

}
