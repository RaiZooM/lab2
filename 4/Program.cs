using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine("Введіть кількість рядків матриці:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість стовпчиків матриці:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Введіть елементи {i + 1}-го рядка через пробіл:");
                string[] rowElements = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(rowElements[j]);
                }
            }


            int[,] sortedMatrix = SortMatrix(matrix);
            PrintMatrix(sortedMatrix);
        }

        static int[,] SortMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            for (int j = 0; j < cols; j++)
            {

                if (j % 2 == 0)
                {
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int k = i + 1; k < rows; k++)
                        {
                            if (matrix[i, j] < matrix[k, j])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[k, j];
                                matrix[k, j] = temp;
                            }
                        }
                    }
                }

                else
                {
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int k = i + 1; k < rows; k++)
                        {
                            if (matrix[i, j] > matrix[k, j])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[k, j];
                                matrix[k, j] = temp;
                            }
                        }
                    }
                }
            }

            return matrix;
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

}
