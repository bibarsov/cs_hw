/*
    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12
 */
namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }

        static int Sum(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }
            return result;
        }
    }
}
