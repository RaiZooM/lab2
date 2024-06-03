using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = InputMatrix();

        SortRowsByMaxElement(matrix);

        Console.WriteLine("Матриця з рядками, впорядкованими за неспаданням максимального елемента:");
        PrintMatrix(matrix);
    }

    static int[,] InputMatrix()
    {
        Console.Write("Введіть кількість рядків матриці: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців матриці: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    static void SortRowsByMaxElement(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int maxI = FindMaxInRow(matrix, i, cols);
                int maxJ = FindMaxInRow(matrix, j, cols);

                if (maxI < maxJ)
                {
                    SwapRows(matrix, i, j);
                }
            }
        }
    }

    static int FindMaxInRow(int[,] matrix, int row, int cols)
    {
        int max = matrix[row, 0];

        for (int j = 1; j < cols; j++)
        {
            if (matrix[row, j] > max)
            {
                max = matrix[row, j];
            }
        }

        return max;
    }

    static void SwapRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
        }
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
}