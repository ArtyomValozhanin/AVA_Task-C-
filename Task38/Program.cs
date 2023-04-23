// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) // создание массива с заданным диапазоном и размером, с автозаполнением
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr) // функция вывода массива на печать.
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1); // округдение до одного знака
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double FindDiffMinMaxElement(double[] arr)
{
    double diffMaxMin = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (round > max) max = round;
        if (round < min) min = round;
        diffMaxMin = max - min;
    }
    return diffMaxMin;
}

// Решение отдельными методами:
// double FindMinElement (double[] arr)
// {
//     double min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double round = Math.Round(arr[i], 1);
//         if(round < min) min = round; 
//     }
//     return min;
// }

// double FindMaxElement (double[] arr)
// {
//     double max = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double round = Math.Round(arr[i], 1);
//         if(round > max) max = round; 
//     }
//     return max;
// }

double[] array = CreateArrayRndDouble(6, -2, 20);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
double diffresult = FindDiffMinMaxElement(array);
Console.WriteLine($"Разница между Max и Min значениями массива = {diffresult}"); 

// double resultMax = FindMaxElement(array);
// double resultMin = FindMinElement(array);
// double diffresult = FindMaxElement(array) - FindMinElement(array);
// Console.WriteLine($"Разница между значениями {resultMax} и {resultMin} составляет: {Math.Round(diffresult, 1)}");