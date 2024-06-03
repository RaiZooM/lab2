using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();
            int result = CalculateSumOfNegativeElements(matrix);
            Console.WriteLine("Сума від'ємних елементів матриці: " + result);
            Console.ReadKey();
        }

        static int[,] GetMatrix()
        {
            Console.WriteLine("Введіть кількість рядків матриці:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість стовпців матриці:");
            int cols = int.Parse(Console.ReadLine());

            return ReadMatrix(rows, cols);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Введіть елементи матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        static int CalculateSumOfNegativeElements(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
