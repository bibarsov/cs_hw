/*
  Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
  является ли оно палиндромом. Через строку нельзя решать само собой.
 */
namespace task19hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPalyndrome(num) ? "Yes" : "No");

        }

        static bool isPalyndrome(int num)
        {
            if (num < 10)
            {
                return true;
            }
            int temp = num;
            int digitsCount = 0;
            while (temp > 0)
            {
                temp /= 10;
                digitsCount++;
            }

            int lNum = num, rNum = num;
            int tempCount = digitsCount;
            while (tempCount > digitsCount / 2)
            {
                int divider = (int)Math.Pow(10, tempCount - 1);

                int right = rNum % 10;
                int left = lNum / divider;
                if (right != left)
                {
                    return false;
                }
                rNum /= 10;
                lNum %= divider;
                tempCount--;
            }
            return true;
        }
    }
}
