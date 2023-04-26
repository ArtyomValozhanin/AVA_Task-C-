// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
   double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
   return dist;
}

Console.WriteLine("Введите координаты первой точки А");
Console.Write("x=");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("y=");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("z=");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки B");
Console.Write("x=");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("y=");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("z=");
int zb = Convert.ToInt32(Console.ReadLine());


double distanse = Distanse(xa, ya, za, xb, yb, zb);
double distanseRound = Math.Round(distanse, 2);
Console.WriteLine($"расстояние между точками = {distanseRound}");
