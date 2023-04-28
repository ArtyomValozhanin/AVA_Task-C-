// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//      1    2    3    4
// 1   |0,5   7   -2  -0,2|
// 2   | 1  -3,3   8  -9,9|
// 3   | 8   7,8  -7,  1 9|

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    //                        0       1
    double[,] matrix = new double[rows, columns]; // 3, 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        } 
    }
    return matrix;
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double round = Math.Round(matrix[i, j], 1);
            Console.Write($"{round, 5} ");
        }
        Console.WriteLine(" |");
    }
}

double[,] array2d = CreateMatrixRndDouble(3, 4, -10, 10);
PrintMatrix(array2d);