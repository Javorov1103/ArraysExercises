using System;

namespace MaxSubMatric3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            //Creating the matrix
            int[,] matrix = new int[n, m];

            //Filling the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }


            //Business Logic
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int first = matrix[row, col];
                    int second = matrix[row, col + 1];
                    int third = matrix[row, col + 2];

                    int fourth = matrix[row + 1, col];
                    int fifth = matrix[row + 1, col + 1];
                    int sixth = matrix[row + 1, col + 2];

                    int seventh = matrix[row + 2, col];
                    int eightth = matrix[row + 2, col + 1];
                    int ninth = matrix[row + 2, col + 2];

                    int currentSum = first + second + third + fourth + fifth + sixth + seventh + eightth + ninth;

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            //Printing the result
            //Console.WriteLine($"{matrix[bestRow,bestCol]}{matrix[bestRow, bestCol+1]}{matrix[bestRow, bestCol+2]}");
            //Console.WriteLine($"{}{}{}");
            //Console.WriteLine($"{}{}{}");

            Console.WriteLine($"Best sum is: {bestSum}");
        }
    }
}
