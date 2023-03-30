/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
namespace task52
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = ReadInteger("Enter m for two-dimensional array:");
            int n = ReadInteger("Enter n for two-dimensional array:");

            int[,] arr = GenerateTwoDimArray(m, n);
            PrintTwoDimArray(arr);
            Console.WriteLine("======================");
            double[] avgs = GetAverageForEveryColumn(arr);
            PrintArray(avgs, "; ");
        }

        static double[] GetAverageForEveryColumn(int[,] arr)
        {
            double[] result = new double[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }
                result[i] = 1.0 * sum / arr.GetLength(0);
            }
            return result;
        }

        static int[,] GenerateTwoDimArray(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            Random randomizer = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = randomizer.Next(0, 10);
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

        static void PrintArray<T>(T[] arr, string delimiter)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + delimiter);
            }
            Console.WriteLine();
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
