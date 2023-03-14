/*
     Задайте массив случайных целых чисел. 
     Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
     Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
     Найти медианное значение первоначалального массива ,
     возможно придется кое-что для этого дополнительно выполнить.
 */
namespace taskHardStat
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
            double[] stat = GetStat(array);
            Console.WriteLine("Min index: {0}, min val: {1}", stat[0], stat[1]);
            Console.WriteLine("Max index: {0}, max val: {1}", stat[2], stat[3]);
            Console.WriteLine("Average: " + stat[4]);
            Console.WriteLine("Median: " + stat[5]);
        }

        static double[] GetStat(int[] arr)
        {
            double minIndex = 0;
            double maxIndex = 0;
            double min = arr[0];
            double max = arr[0];
            double avg = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                avg += arr[i];
                if (arr[i] > max)
                {
                    maxIndex = i;
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    minIndex = i;
                    min = arr[i];
                }
            }
            double[] result = new double[6]; //double because of median's value type
            result[0] = minIndex;
            result[1] = min;
            result[2] = maxIndex;
            result[3] = max;
            result[4] = avg / arr.Length;
            Array.Sort(arr);
            result[5] = arr.Length % 2 == 0 ? (arr[(arr.Length / 2) - 1] + arr[arr.Length / 2]) / 2.0 : arr[arr.Length / 2];
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
