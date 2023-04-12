// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int MidleDigit (int num)
{
    int firstDigit = num % 10;
    int secondDigit = (num % 100 - firstDigit)/10;
    return secondDigit;
}

Console.WriteLine("Введите любое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;
if (number >= 100 && number <= 999 )
{
    int result = MidleDigit(number);
     Console.WriteLine($"вторая цифра: {result}");
}
else
{
         Console.WriteLine("число не трехзначное");
}
