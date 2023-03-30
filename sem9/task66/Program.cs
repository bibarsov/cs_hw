/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
namespace task64
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = ReadInteger("Enter M:");
            int n = ReadInteger("Enter N:");
            long sum = GetSumOfNaturalInRange(m, n);
            Console.WriteLine(sum);
        }

        static long GetSumOfNaturalInRange(int m, int n)
        {
            if (m == n)
            {
                return m;
            }
            return m + GetSumOfNaturalInRange(m + 1, n);

        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
