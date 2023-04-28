// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // 3, 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

void SirchMatrixElement(int numA, int numB, int[,] matrix)
{
    int sirch = 0;
    if (numA < matrix.GetLength(0) && numB < matrix.GetLength(1))
    {sirch += matrix[numA, numB]; Console.WriteLine($"Заданным параметрам соответствует число: {sirch}");}
    else {Console.WriteLine($"Такого элемента в массиве нет");}
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2d);
Console.WriteLine("Введите позицию элемента по строке: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по столбцу: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA >= 0 && numberB >=0) {SirchMatrixElement(numberA, numberB, array2d);}
else {Console.WriteLine($"неверный ввод элемента");}
