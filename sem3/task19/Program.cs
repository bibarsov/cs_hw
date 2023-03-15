/*
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом. Через строку решать нельзя.

    14212 -> нет
    12821 -> да
    23432 -> да
*/
namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 10000 || num > 99999)
            {
                Console.WriteLine("Should be 5-digit number");
                return;
            }


            Console.WriteLine(isPalyndrome(num) ? "Yes" : "No");

        }

        static bool isPalyndrome(int num)
        {
            int d1 = num % 10; num /= 10;
            int d2 = num % 10; num /= 10;
            num /= 10;
            int d4 = num % 10; num /= 10;
            int d5 = num % 10;
            return d1 == d5 && d2 == d4;
        }
    }
}
