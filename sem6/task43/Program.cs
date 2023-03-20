/*
   Напишите программу, которая найдёт точку пересечения двух прямых, 
   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
   значения b1, k1, b2 и k2 задаются пользователем.

   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */
namespace task43
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = ReadInteger("Enter b1:");
            int k1 = ReadInteger("Enter k1:");
            int b2 = ReadInteger("Enter b2:");
            int k2 = ReadInteger("Enter k2:");

            // k1 * x + b1 - k2 * x - b2 = 0
            // x (k1 - k2) + b1-b2 = 0
            // x (k1 -k2) = b2 - b1
            // x = (b2-b1)/(k1-k2)
            // y = k2 * x + b2
            double x = 1.0 * (b2 - b1) / (k1 - k2);
            double y = k2 * x + b2;
            Console.WriteLine("({0}; {1})", x, y);
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
