/*
  Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
  и возвращает позицию этого элемента или же указание, что такого элемента нет.
  Например, задан массив:
  1 4 7 2
  5 9 2 3
  8 4 2 4
  17 -> такого числа в массиве нет
 */
namespace task50
{
    class Program
    {
        static void Main(string[] args)
        {
            int search = ReadInteger("Enter a number to find a position:");
            int[,] array = GenerateTwoDimArray(3, 4);
            PrintTwoDimArray(array);
            var tuple = SearchNumberInTwoDimArray(array, search);
            if (tuple != null)
            {
                Console.WriteLine(search + " found at: " + tuple);
            }
            else
            {
                Console.WriteLine(search + ": no number like this.");
            }
        }

        static Tuple<int, int>? SearchNumberInTwoDimArray(int[,] array, int search)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == search)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return null;
        }

        static int[,] GenerateTwoDimArray(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            Random randomizer = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = randomizer.Next(-10, 10);
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
