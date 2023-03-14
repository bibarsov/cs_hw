/*
  Задайте массив вещественных чисел. 
  Найдите разницу между максимальным и минимальным элементов массива.
  [3 7 22 2 78] -> 76
 */
namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = ReadInteger("Enter array length:");
            double min = ReadDouble("Enter range minimum for a value in array (can be double):");
            double maxExcl = ReadDouble("Enter range maximum for a value in array (can be double, exclusive):");

            double[] array = GenerateArray(len, min, maxExcl);
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine(GetMaxMinDiff(array));
        }

        static double GetMaxMinDiff(double[] arr)
        {
            if (arr.Length == 0) {
                throw new ArgumentException("Array should be of length 1 or more");
            }
            double min = arr[0];
            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return max - min;
        }

        static double[] GenerateArray(int len, double min, double maxExclusive)
        {
            double[] result = new double[len];
            Random randomizer = new Random();
            for (int i = 0; i < len; i++)
            {
                result[i] = min + randomizer.NextDouble() * (maxExclusive - min);
            }
            return result;
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static double ReadDouble(string message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
