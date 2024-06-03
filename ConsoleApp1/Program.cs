using System;

class Program11
{
    static int SumOfNegativeElements(int[,] matrix)
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

    static void Main01(string[] args)
    {
        Console.WriteLine("Введіть кількість рядків матриці:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість стовпців матриці:");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int result = SumOfNegativeElements(matrix);
        Console.WriteLine("Сума від'ємних елементів матриці: " + result);
        Console.ReadKey();
    }
}
