/*
    Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет.Через строку решать нельзя.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 
*/

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int d1 = -1;
            int d2 = -1;
            int d3 = -1;

            while (num > 0)
            {
                if (d2 != -1)
                {
                    d3 = d2;
                }
                if (d1 != -1)
                {
                    d2 = d1;
                }

                d1 = num % 10;
                num /= 10;
            }
            Console.WriteLine(d3 != -1 ? "Digit: " + d3 : "There is no such digit.");
        }
    }
}
