// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(0, 1001); 
Console.WriteLine($"Случайное трехзначноечисло в диапазоне 0-999 -> {number}");

int DelCenter (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int answer = firstDigit * 10 + thirdDigit;
    return answer;
}
Console.WriteLine($"двузначное число {DelCenter(number)}");
