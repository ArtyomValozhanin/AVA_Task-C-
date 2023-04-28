// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2, 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1

Console.WriteLine("Введите коэффициент b1: ");
double numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1: ");
double numk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2: ");
double numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2: ");
double numk2 = Convert.ToInt32(Console.ReadLine());

if (numk2 == numk1) {Console.WriteLine("прямые параллельны");}
// return;

double resultX = FindCoordinateX(numb1, numk1, numb2, numk2);
double resultXRound = Math.Round(resultX, 2);
double resultY = FindCoordinateY(numb1, numk1, numb2, numk2);
double resultYRound = Math.Round(resultY, 2);
Console.WriteLine($"({resultXRound}; {resultYRound})");

double FindCoordinateX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double FindCoordinateY(double b1, double k1, double b2, double k2)
{
    return k1 * (b2 - b1) / (k1 - k2) + b1;
}