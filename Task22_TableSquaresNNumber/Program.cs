// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void TableAllSquares(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}  {count * count, 3}"); // 3 - резервирование места под кол-во символов
        count++;
    }
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

TableAllSquares(number);