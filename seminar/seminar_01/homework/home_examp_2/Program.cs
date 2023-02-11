// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int x, y, z;
Console.WriteLine("Ввведите первое число: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Ввведите третье число: ");
z = int.Parse(Console.ReadLine());

if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("максимальное число: " + x);
    }
    else
    {
        Console.WriteLine("максимальное число: " + z);
    }
}
else
{
    if (y > z)
    {
        Console.WriteLine("максимальное число: " + y);
    }
    else
    {
        Console.WriteLine("максимальное число: " + z);
    }
}
