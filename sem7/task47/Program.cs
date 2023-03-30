/*
    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.
    0,5  7     -2    -0,2
    1   -3,3   8     -9,9
    8   7,8    -7,1  9
 */
namespace task47
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = ReadInteger("Enter m for two-dimensional array:");
            int n = ReadInteger("Enter n for two-dimensional array:");


            PrintTwoDimArray(GenerateTwoDimArray(m, n));
        }

        static double[,] GenerateTwoDimArray(int rows, int columns)
        {
            double[,] result = new double[rows, columns];
            Random randomizer = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = randomizer.Next(-30, 30) + Math.Round(randomizer.NextDouble(), 2);
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

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
