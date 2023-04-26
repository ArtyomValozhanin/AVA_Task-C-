// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void TableNCubs(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}  {count * count * count, 4}"); // 3 - резервирование места под кол-во символов
        count++;
    }
}

Console.Write("Ведите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Таблица чисел^3 от еденицы до введеного:");
TableNCubs(number);
