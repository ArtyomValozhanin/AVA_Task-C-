// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void CreateArray(int[] array)
{
    Random random = new Random(); // оптимизация объекта Random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 999);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int CheckEvenNumber(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) num += arr[i]/arr[i];
    }
  return num;
}

int[] array = new int [8];
CreateArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

int resultEven = CheckEvenNumber(array);
Console.WriteLine(resultEven);