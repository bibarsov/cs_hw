/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Please, enter a value between 1 and 7");
                return;
            }
            Console.WriteLine((day - 5) > 0 ? "Yes" : "No");
        }
    }
}
