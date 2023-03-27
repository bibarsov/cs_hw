/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
namespace task58
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = ReadInteger("Enter n (first matrix):");
            int m1 = ReadInteger("Enter m (first matrix):");
            int n2 = ReadInteger("Enter n (second matrix):");
            int m2 = ReadInteger("Enter m (second matrix):");
            if (m1 != n2)
            {
                throw new ArgumentException("No solution. Columns count of a first matrix should be the same value as row count of a second.");
            }

            int[,] matrix1 = GenerateTwoDimArray(n1, m1);
            int[,] matrix2 = GenerateTwoDimArray(n2, m2);

            PrintTwoDimArray(matrix1);
            Console.WriteLine("----------------------");
            PrintTwoDimArray(matrix2);
            Console.WriteLine("----------------------");
            int[,] result = MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("------result----------");
            PrintTwoDimArray(result);

        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {

                    int temp = 0;

                    for (int idx = 0; idx < matrix1.GetLength(1); idx++)
                    {
                        Console.WriteLine("i: {0}, j:{1}, idx:{2}", i, j, idx);
                        temp += matrix1[i, idx] * matrix2[idx, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[,] GenerateTwoDimArray(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            Random randomizer = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = randomizer.Next(0, 5);
                }
            }
            return result;
        }

        static void PrintTwoDimArray<T>(T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
