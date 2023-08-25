
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMeanColumns(int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumColumns = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumns += matrix[i, j];
        }
        sumColumns = Math.Round(sumColumns/matrix.GetLength(0), 1);
        if (j == matrix.GetLength(1) - 1) Console.Write($" {sumColumns}.");
        else Console.Write($" {sumColumns}; ");
    }   
}

int rows = 0;
int columns = 0;
while (rows <= 0 || columns <= 0)
{
    Console.Clear();
    Console.WriteLine("Количество строк и столбцов массива должно быть положительное.");
    Console.Write("Введите количество строк массива: ");
    rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    columns = Convert.ToInt32(Console.ReadLine());
}
int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 9);
PrintMatrix(array2d);
Console.Write($"Среднее арифметическое каждого столбца равно: ");
PrintArithmeticMeanColumns(array2d);




