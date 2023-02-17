//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int ShowThird(int number)
{

    int thirdNumb = number % 10;
    return thirdNumb;

}
int number = new Random().Next(10, 999);

if (number >= 100 && number < 1000)
{
    Console.WriteLine(number);
    Console.WriteLine(ShowThird(number));
}
else
{
    Console.WriteLine("третьей цифры нет");
}

