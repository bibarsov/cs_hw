/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
 */
namespace task64
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInteger("Enter N:");
            if (n < 1)
            {
                Console.WriteLine("Only N>=1 should be provided.");
                return;
            }
            PrintNaturalNumsUpTo(n);
            Console.WriteLine();
        }

        static int PrintNaturalNumsUpTo(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return 0;
            }
            Console.Write("{0}, ", n);

            return PrintNaturalNumsUpTo(n - 1);

        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
