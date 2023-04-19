// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigit(number);
Console.WriteLine($"Сумма чисел в числе {number} = {result}");

int SumDigit(int num)
{
    int count = 0;
   while (num > 1)
    {
        count = count + num % 10 - 1;
        num = num / 10;             
        count++; 
    }
    return count;
}
