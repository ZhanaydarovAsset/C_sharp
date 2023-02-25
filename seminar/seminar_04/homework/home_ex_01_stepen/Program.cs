// Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

int[] Promt(string message)
{
    Console.WriteLine(message);
    int[] numbAandB = new int[2];
    for (int i = 0; i < 2; i++)
    {
        string valve = Console.ReadLine()!;
        int result = Convert.ToInt32(valve);
        numbAandB[i] = result;
    }

    return numbAandB;
}

double Degree(int numbA, int numbB)
{
    double exponentNumb = numbA;
    for (int i = 0; i < numbB - 1; i++)
    {
        exponentNumb = numbA * exponentNumb;
    }
    return exponentNumb;
}

int[] numbers = Promt("Введите два числа :");
string AandB = string.Join(", ", numbers);
Console.WriteLine($"Числа А и В: {AandB}");
double AExponentB = Degree(numbers[0], numbers[1]);

Console.WriteLine($"число {numbers[0]} в степени {numbers[1]} равно {AExponentB}");

