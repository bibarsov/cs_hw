//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
namespace task4
{
    class Program
    {
        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max;
            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("Max number is: {0}", max);
        }
    }
}
