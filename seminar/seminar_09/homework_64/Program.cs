// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

using static Library.Shared;

int numb = InputIntUser("Введите число: ");
string Text (int n)
{
    string text = String.Empty;
    if (n == 1) return text = $"{n}";
    else return  text += $"{n}, {Text(n-1)} ";
}
Console.WriteLine(Text(numb));