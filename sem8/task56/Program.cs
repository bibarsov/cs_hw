/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */
namespace task56
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInteger("Enter n:");
            int m = ReadInteger("Enter m:");
            int[,] twoDimArr = GenerateTwoDimArray(n, m);

            PrintTwoDimArray(twoDimArr);
            int? rowIndex = GetRowIndexWithSmallestSum(twoDimArr);
            if (rowIndex != null)
            {
                Console.WriteLine("{0} row", rowIndex + 1);
            }
        }

        static int? GetRowIndexWithSmallestSum(int[,] twoDimArr)
        {
            int? rowSmallestSum = null;
            int? rowSmallestSumIdx = null;
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < twoDimArr.GetLength(1); j++)
                {
                    sum += twoDimArr[i, j];
                }

                if (rowSmallestSum == null || sum < rowSmallestSum)
                {
                    rowSmallestSum = sum;
                    rowSmallestSumIdx = i;
                }
            }
            return rowSmallestSumIdx;
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
                    result[i, j] = randomizer.Next(0, 30);
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

