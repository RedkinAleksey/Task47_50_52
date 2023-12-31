﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве 

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
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
       // Console.WriteLine("  |");
       Console.WriteLine();
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

Console.WriteLine("Введите строку позиции элемента. (Отсчет начинается с нуля.)");
int rowsElement = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец позиции элемента. (Отсчет начинается с нуля.)");
int columsElement = Convert.ToInt32(Console.ReadLine());

if (rowsElement >= rows || columsElement >= columns || rowsElement < 0 || columsElement < 0)
{
    Console.WriteLine($"{rowsElement}, {columsElement} -> Такого элемента нет.");
}
else
{
    Console.WriteLine($"Элемент равен {array2d[rowsElement, columsElement]}.");
}