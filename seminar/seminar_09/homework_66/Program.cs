// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using static Library.Shared;
int m = InputIntUser("enter M: ");
int n = InputIntUser("enter N: ");

int Sum(int m, int n)
{
    if (n < m) return 0;
    
    else return m + Sum(m+1, n);
}
Console.WriteLine(Sum(m, n));
