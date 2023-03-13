/*
    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)
    2, 4 -> 16
 */
namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Pow(a, b));
        }

        static int Pow(int n, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
