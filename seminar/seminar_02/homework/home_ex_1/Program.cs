﻿
//принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ShowSecondNumber(int number)
{
    int secondNumber = (number % 100) / 10;
    return secondNumber;
}
int number = new Random().Next(100, 999);
Console.WriteLine(number);
Console.WriteLine(ShowSecondNumber(number));

