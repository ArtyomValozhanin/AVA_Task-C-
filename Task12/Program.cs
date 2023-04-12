// 2. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// 16, 4 -> кратно
int Remainder (int num1, int num2)
{
    int remainder = num1 % num2;
    return remainder;
}

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 1");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Remainder(number1, number2);

if (result == 0)
{
    Console.WriteLine("первое число кратно второму");
}
else
{
     Console.WriteLine($"числа не кратны {Remainder(number1, number2)}");
}