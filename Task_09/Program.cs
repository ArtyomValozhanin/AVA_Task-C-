// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99 + 1
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");
int FirstDigit = number / 10;
int SecondDigit = number % 10;
// if (FirstDigit > SecondDigit) 
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {FirstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {SecondDigit}");
// }

int maxDigit = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");