// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekEnd(int num)
{
    return num / 6 == 1 || num / 7 == 1;
}

Console.WriteLine("Введите число дня недели от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    bool result = WeekEnd(number);
    if (result == true) Console.WriteLine("да");
    if (result == false) Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}