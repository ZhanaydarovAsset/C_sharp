//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] Promt(string message)
{
    Console.WriteLine(message);
    int[] koordinate = new int[3];
    for (int i = 0; i < 3; i++)
    {
        string valve = Console.ReadLine();
        int result = Convert.ToInt32(valve);
        koordinate[i] = result;
    }

    return koordinate;
}

int[] pointA = Promt("Введите координаты для точки А x, y, z");
var tochkaA = string.Join(" ", pointA);
Console.WriteLine($"Точка А [{tochkaA}]");

int[] pointB = Promt("Введите координаты для точки B x, y, z");
var tochkaB = string.Join(" ", pointB);
Console.WriteLine($"Точка B [{tochkaB}]");

double Distance(int[] dotA, int[] dotB)
{
    double lenXY = Math.Pow((dotA[0]-dotB[0]), 2) + Math.Pow((dotA[1]-dotB[1]), 2);
    double lenZ = Math.Sqrt(Math.Pow((dotA[2]-dotB[2]), 2) + lenXY);
    return lenZ;
}

double A = Distance(pointA, pointB);
Console.WriteLine(A);