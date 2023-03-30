/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */
namespace task68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning: error prone solution (Stack overflow).");
            Console.WriteLine("Please use arguments those are easy to compute within this function.");
            int m = ReadInteger("Enter M:");
            int n = ReadInteger("Enter N:");

            if (m < 0 || n < 0)
            {
                Console.WriteLine("M or/and N should be non-negative numbers");
                return;
            }

            long result = Ackermann(m, n);
            Console.WriteLine(result);
        }

        static long Ackermann(long m, long n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }

            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
