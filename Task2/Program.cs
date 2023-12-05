// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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

        
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        
        SwapFirstAndLastRows(matrix);

        
        Console.WriteLine("\nМассив после замены:");
        PrintMatrix(matrix);
    }

    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    
    static void SwapFirstAndLastRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        
        if (rows >= 2)
        {
            
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[0, j];
                matrix[0, j] = matrix[rows - 1, j];
                matrix[rows - 1, j] = temp;
            }
        }
    }
}