﻿//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.Write("max " + a);
    Console.WriteLine(" min " + b);
}
else
{
    Console.Write("max " + b);
    Console.WriteLine(" min " + a);
}