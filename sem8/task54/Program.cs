/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
namespace task54
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInteger("Enter n:");
            int m = ReadInteger("Enter m:");
            int[,] twoDimArr = GenerateTwoDimArray(n, m);

            PrintTwoDimArray(twoDimArr);
            Console.WriteLine(".................");
            Console.WriteLine("Sorting...");
            SortTwoDimArr(twoDimArr);
            Console.WriteLine(".................");
            PrintTwoDimArray(twoDimArr);
        }

        static void SortTwoDimArr(int[,] twoDimArr)
        {
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                bool sorted = false;
                while (!sorted)
                {
                    sorted = true;
                    int biggestIdx = 0;
                    for (int j = 1; j < twoDimArr.GetLength(1); j++)
                    {
                        if (twoDimArr[i, j] > twoDimArr[i, biggestIdx])
                        {
                            sorted = false;
                            int temp = twoDimArr[i, biggestIdx];
                            twoDimArr[i, biggestIdx] = twoDimArr[i, j];
                            twoDimArr[i, j] = temp;
                            biggestIdx = j;
                        }
                    }
                    if (sorted)
                    {
                        break;
                    }
                }

            }
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
