// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) Console.WriteLine($"Число B должно быть положительным"); // <- сообщить что ввод с "-" не верный
int result = PowNumbers(numberA, numberB);
Console.WriteLine($"{numberA} ^{numberB} -> {result}");

int PowNumbers(int numA, int numB) // через цикл "for"
{
    int powNum = 0;
        int temp = numA;
    for (int i = 1; i < numB; i++)
    {
        checked
        {
            powNum = temp * numA;
            temp = powNum;
        }
    }
    return powNum;
}
// int PowNumbers(int numA, int numB) // через цикл "while"
// {
//     int powNum = 0;
//     int temp = numA;
//     int count = 1;
//     while (count <= numB - 1)
//     {
//         checked // Проверка на переполнение
//         {
//             powNum = temp * numA;
//             temp = powNum;
//             count ++;
//         }
//     }
//     return powNum;
// }