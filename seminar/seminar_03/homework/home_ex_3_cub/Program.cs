//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27

int Promt(string message)
{
    Console.WriteLine(message);
    string valve = Console.ReadLine()!;
    int result = Convert.ToInt32(valve);
    return result;
}

int size = Promt("Введите число N: ");

string Table(int numb)
{
    string text = "";

    for (int i = 1; i <= size; i++)
    {
        text= text + $"куб числа {i} = {i * i * i}"+"\n";

    }
    return text;
}

string newText = Table(size);

Console.WriteLine(newText);
