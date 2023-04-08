// Напишите програму которая будет выдававать
// название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine ("это Понедельник");
}
else if (number == 2)
{
     Console.WriteLine ("это Вторник");
}
else if (number == 3)
{
    Console.WriteLine ("это Среда");
}
else if (number == 4)
{
    Console.WriteLine ("это Четверг");
}
else if (number == 5)
{
    Console.WriteLine ("это Пятница");
}
else if (number == 6)
{
    Console.WriteLine ("это Суббота");
}
else if (number == 7)
{
    Console.WriteLine ("это Воскресенье");
}
else
{
    Console.WriteLine ("Такого дня недели нет");
}
