/*

Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
 
 */
namespace task2
{
    class Program
    {
        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Bigger number: {0}, smaller number: {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Bigger number: {0}, smaller number: {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("Numbers equal to each other");
            }
        }
    }
}
