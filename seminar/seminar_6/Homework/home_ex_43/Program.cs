// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//-(b1-b2)/(k1-k2)=x  => -(2-4)/(5-9)=x
using static Library.Shared;


double k1 = InputDoubleUser("k1=");
double b1 = InputDoubleUser("b1=");
double k2 = InputDoubleUser("k2=");
double b2 = InputDoubleUser("b2=");
if(k1 != k2){
double x = -(b1-b2)/(k1-k2);
double y = k2 * x + b2;
double [] intersection = {x, y};

Console.WriteLine(DoubleArrayJoinToString(intersection));
}
else{
    Console.WriteLine("не пересекаются!");
}
