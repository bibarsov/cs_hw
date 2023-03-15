/*
    Напишите программу, которая выводит на экран числа от 1 до 100. 
    При этом вместо чисел, кратных трем, программа должна выводить слово Fizz,
    а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, 
    то программа должна выводить слово FizzBuzz. 
*/

namespace taskFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            bool flag = false;
            while (n <= 100)
            {
                if (n % 3 == 0)
                {
                    flag = true;
                    Console.Write("Fizz");
                }
                if (n % 5 == 0)
                {
                    flag = true;
                    Console.Write("Buzz");
                }
                if (!flag)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
                flag = false;
                n++;
            }
        }
    }
}
