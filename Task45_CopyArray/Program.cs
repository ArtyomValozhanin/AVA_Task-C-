// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


void CreateArray(int[] array)
{
    Random random = new Random(); // оптимизация объекта Random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10, 99);
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

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < length; i++)
    {
         newArr[i] = arr[i];
    }
    return newArray;
}

int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);
Console.WriteLine();
int[] newArray=CreateCopyArray(array);
// newArray[0] = 10;
PrintArray(newArray);