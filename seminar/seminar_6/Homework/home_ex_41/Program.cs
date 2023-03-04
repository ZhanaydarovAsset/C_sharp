// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using static Library.Shared;




// string fromUser = " ";

// int count = 0;
// while (fromUser != "end")
// {
//     Console.WriteLine("int or end");
//     fromUser = Console.ReadLine()!;
//     count++;
//     Console.WriteLine(fromUser+" "+count);
// }

int size = InputIntUser("Введите размер массива: ");

int[] array = new int[size];
Console.WriteLine("r = random or m = manual");
string fillMethod = Console.ReadLine()!;

if (fillMethod == "r")
{
    FillArray(array, -10, 10);
}
else
{
    for (int i = 0; i < size; i++)
    {
        array[i] = InputIntUser(" Vvedite chislo");
    }
}

Console.WriteLine(ArrayJoinToString(array));
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("числа больще нуля: "+count);
