/*
   Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
   *Пример:*
   - для k = 9 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
 */
namespace taskNegaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter k:");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] result = GetNegaFibonacci(k);
            Console.WriteLine(string.Join(",", result));
        }

        static int[] GetNegaFibonacci(int k)
        {
            if (k == 1)
            {
                return new int[] { 0 };
            }
            int[] fibonacciNums = new int[k * 2 - 1];
            fibonacciNums[k - 1] = 0;
            fibonacciNums[k] = 1;
            fibonacciNums[k - 2] = -1;
            bool negativeFlag = true;
            for (int i = k + 1; i < k * 2 - 1; i++)
            {
                fibonacciNums[i] = fibonacciNums[i - 1] + fibonacciNums[i - 2];
                fibonacciNums[k - 2 - (i - k)] = negativeFlag ? -fibonacciNums[i] : fibonacciNums[i];
                negativeFlag = !negativeFlag;
            }
            return fibonacciNums;
        }
    }
}
