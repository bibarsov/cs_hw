/*
 * Задайте одномерный массив, заполненный случайными числами.
 * Найдите сумму элементов, стоящих на нечётных позициях.
 */
namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = ReadInteger("Enter array length:");
            int min = ReadInteger("Enter range minimum for a value in array:");
            int max = ReadInteger("Enter range maximum for a value in array:");

            int[] array = GenerateArray(len, min, max + 1);
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine(GetOddSum(array));
        }

        static long GetOddSum(int[] arr)
        {
            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result+= arr[i];
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
