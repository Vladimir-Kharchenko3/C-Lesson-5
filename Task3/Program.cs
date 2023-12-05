// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.


using System;

class Program
{
    static void Main()
    {
        // Задаем прямоугольный двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        // Находим строку с наименьшей суммой элементов
        int minSumRowIndex = FindRowWithMinSum(matrix);

        // Выводим результат
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}");
    }

    // Метод для вывода прямоугольного двумерного массива
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

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Если массив пуст, возвращаем -1 (нет строк)
        if (rows == 0 || cols == 0)
        {
            return -1;
        }

        int minSum = int.MaxValue;
        int minSumRowIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;

            // Считаем сумму элементов в текущей строке
            for (int j = 0; j < cols; j++)
            {
                currentSum += matrix[i, j];
            }

            // Если текущая сумма меньше минимальной, обновляем значения
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }
}