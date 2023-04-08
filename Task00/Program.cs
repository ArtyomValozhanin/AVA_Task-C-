// Напишите программу которая на вход принимает число и выдает его
// квадрат (число умноженное само на себя)
// например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"квадрат числа {number} = {square}");
