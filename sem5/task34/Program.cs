/*
  Задайте массив заполненный случайными положительными трёхзначными числами. 
  Напишите программу, которая покажет количество чётных чисел в массиве.
  [345, 897, 568, 234] -> 2
 */
namespace task34
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = ReadInteger("Enter array length:");
            int min = ReadInteger("Enter range minimum for a value in array:");
            int max = ReadInteger("Enter range maximum for a value in array:");

            int [] array = GenerateArray(len, min, max + 1);
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine(GetEvenCount(array));
        }

        static int GetEvenCount(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

        static int[] GenerateArray(int len, int min, int maxExclusive)
        {
            int[] result = new int[len];
            Random randomizer = new Random();
            for (int i = 0; i < len; i++)
            {
                result[i] = randomizer.Next(min, maxExclusive);
            }
            return result;
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
