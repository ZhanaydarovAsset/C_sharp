//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int Promt(string message)
{
    Console.WriteLine(message);
    string valve = Console.ReadLine()!;
    int result = Convert.ToInt32(valve);
    return result;
}

int number = Promt("Введите пятизначное число");
Console.WriteLine();

int Writeback (int number)
{
    int newNumber = 0;
    while (number>0)
    {
        int temp = number % 10;
        newNumber = newNumber * 10 + temp;
        number = number / 10;
    }

    return newNumber;
}

int newNum = Writeback(number);
if (newNum == number)
{
    Console.WriteLine("полиндром");
}
else{
    Console.WriteLine("не полиндром");
}
