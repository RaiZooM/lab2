using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмірність квадратної матриці:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = ReadMatrix(n);

        ExchangeElements(matrix);

        Console.WriteLine("Матриця після обміну елементів:");
        PrintMatrix(matrix);

        Console.ReadKey();
    }

    static int[,] ReadMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть елементи {i + 1}-го рядка через пробіл:");
            string[] elements = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        return matrix;
    }

    static void ExchangeElements(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int temp = matrix[i, 0];
            matrix[i, 0] = matrix[i, n - 1 - i];
            matrix[i, n - 1 - i] = temp;
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
