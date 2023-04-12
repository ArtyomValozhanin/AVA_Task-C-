// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit (int num)
{
    int count = num;
    while (num > 999)
    {
        num = num / 10;
        count++;
    }
        return num % 10;
}

Console.WriteLine("Введите любое число больше 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int result = ThirdDigit(number);
     Console.WriteLine($"третья цифра: {result}");
}
else
{
         Console.WriteLine("третьей цифры нет");
}
