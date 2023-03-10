/*
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

 456 -> 5
 782 -> 8
 918 -> 1
 */
namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 100 || num >= 1000)
            {
                Console.WriteLine("You entered non three-digit number. Please, try again.");
                return;
            }
            int digit = num % 100 / 10;
            Console.WriteLine(digit);
        }
    }
}
