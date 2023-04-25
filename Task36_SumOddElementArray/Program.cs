// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max) // создание массива с заданным диапазоном и размером, с автозаполнением
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr) // функция вывода массива на печать.
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int SumElementOddDigit (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(6, 0, 10);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

int result = SumElementOddDigit(array);
Console.Write(result);