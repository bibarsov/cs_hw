/*
Напишите программу, которая заполнит спирально массив 4 на 4.
На входе - натуральное число от пользователя, например 4.
Тогда на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
using System.Drawing;

namespace task62
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadInteger("Enter size:");
            int[,] result = new int[size, size];

            int[,] arr = CreateSpiralArray(result);
            PrintTwoDimIntArray(arr);
        }

        static int[,] CreateSpiralArray(int[,] arr)
        {

            return CreateSpiralArray(
                arr, 0, 0, 0, arr.GetLength(0) - 1, arr.GetLength(0) - 1, 0, arr.GetLength(0) - 1, arr.GetLength(0) - 1, 0
            );
        }

        static int[,] CreateSpiralArray(int[,] arr, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int counter)
        {
            int topLength = y2 - y1;
            if (topLength == 0)
            {
                arr[x1, y1] = counter++;
                return arr;
            }
            if (topLength == 1)
            {
                arr[x1, y1] = counter++;
                arr[x2, y2] = counter++;
                arr[x4, y4] = counter++;
                arr[x3, y3] = counter++;
                return arr;
            }

            //filling top
            for (int i = y1; i <= y2; i++)
            {
                arr[x1, i] = counter++;
            }
            //filling right
            for (int i = x2 + 1; i <= x3; i++)
            {
                arr[i, y2] = counter++;
            }
            //filling down
            for (int i = y4 - 1; i >= y3; i--)
            {
                arr[x3, i] = counter++;
            }
            //filling left
            for (int i = x3 - 1; i > x1; i--)
            {
                arr[i, y3] = counter++;
            }
            return CreateSpiralArray(arr, x1 + 1, y1 + 1, x2 + 1, y2 - 1, x3 - 1, y3 + 1, x4 - 1, y4 - 1, counter);
        }

        static void PrintTwoDimIntArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write(arr[i, k].ToString("00.##") + " ");
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
