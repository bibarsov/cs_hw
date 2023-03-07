/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int evenNum = 2;
            if (evenNum <= num)
            {
                bool firstItemFlag = true;
                while (evenNum <= num)
                {
                    Console.Write(firstItemFlag ? evenNum : ", " + evenNum);
                    evenNum = evenNum + 2;
                    firstItemFlag = false;
                }
            }
            else
            {
                Console.WriteLine("There are no even numbers less than or equal to " + num);
            }
        }
    }
}