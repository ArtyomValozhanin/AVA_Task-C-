// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// [0, 7, 8, -2, -2] -> 2
// [-1, -7, 567, 89, 223] -> 3

int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Ниже, заполните массив числами:");
    for (int i = 0; i < array.Length; i++)
    {
                array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int CheckPositivNumber(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) num = num + 1;
    }
  return num;
}

Console.Write("Введите длину массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(lengthArray);

Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

int resultPositiv = CheckPositivNumber(array);
Console.WriteLine(resultPositiv);