// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно "палиндромом".
// ! Выполнить с помощью числовых операций (целочисленное деление, остаток от деления)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool PalindromeCheck(int num)
{
    return (num / 10000 == num % 10) || (num / 1000 == num % 100);
}

Console.WriteLine("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number >= 10000 && number <= 99999)
{
    bool result = PalindromeCheck(number);
    Console.Write(result ? "да, число палиндром" : "нет, число не палиндром");
}
else
{
    Console.WriteLine("это не пятизначное число");
}
