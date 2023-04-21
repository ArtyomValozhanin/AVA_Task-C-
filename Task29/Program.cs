// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int [8];
CreateArray(array);
PrintArray(array);
Console.Write("\b\b");
Console.Write(" - > [");
PrintArray(array);
Console.Write("\b\b");
Console.Write("]");

void CreateArray(int[] array)
{
    Random random = new Random(); // оптимизация объекта Random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}