// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int n, i;

i = 2;
n = int.Parse(Console.ReadLine());
while (i < n)
{
    Console.Write(i.ToString() + ", ");
    i = i + 2;
}
