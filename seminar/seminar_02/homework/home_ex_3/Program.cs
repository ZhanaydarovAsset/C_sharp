//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string Holiday(int day)
{
    string weekend = "выходной";
    string noWeekend = "не выходной";
    if (day > 5)
    {
        return weekend;
    }
    return noWeekend;
}

int day = new Random().Next(1, 8);
Console.WriteLine(day);
Console.WriteLine(Holiday(day));
