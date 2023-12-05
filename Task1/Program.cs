//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        int result = GetElementValue(matrix, row, col);
        if (result != int.MinValue)
        {

            Console.WriteLine($"Значение элемента [{row},{col}]: {result}");
        }
        else
        {

            Console.WriteLine($"Элемента [{row},{col}] не существует в массиве.");
        }
    }


    static int GetElementValue(int[,] matrix, int row, int col)
    {

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);


        if (row >= 0 && row < rows && col >= 0 && col < cols)
        {

            return matrix[row, col];
        }
        else
        {

            return int.MinValue;
        }
    }
}