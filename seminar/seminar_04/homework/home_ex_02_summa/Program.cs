//  Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11.  //82 -> 10

int Promt(string message)
{
    Console.WriteLine(message);
    string valve = Console.ReadLine()!;
    int result = Convert.ToInt32(valve);
    return result;
}

int Summ(int arg)
{
    int remaind = 0;
    while (arg > 0)
    {
        remaind = arg % 10 + remaind;
        arg /= 10;
    }
    return remaind;
}

int number = Promt("Введите число");
Console.WriteLine();

int sumNumb = Summ(number);
Console.WriteLine($"Сумма цифр числа: {sumNumb}");

