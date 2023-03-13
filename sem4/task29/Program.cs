/*
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33-> [6, 1, 33]
 */
namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = ReadInteger("Enter array length:");
            int min = ReadInteger("Enter range minimum for a value in array:");
            int max = ReadInteger("Enter range maximum for a value in array:");

            Console.WriteLine(string.Join(",", GenerateArray(len, min, max + 1)));
        }

        private static int[] GenerateArray(int len, int min, int maxExclusive)
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
