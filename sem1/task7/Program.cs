/*
 Напишите программу, которая принимает на вход целое число любой разрядности 
 и на выходе показывает третью цифру слева этого числа или говорит, 
 что такой цифры нет. Через строку решать нельзя.
    456111  -> 6
    78      -> нет
    9146548 -> 4
    3       -> нет
*/
namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int?[] arr = new int?[3];

            while (num > 0)
            {
                int? d1 = arr[0];
                int? d2 = arr[1];

                if (d1 != null)
                {
                    arr[1] = d1;
                }
                if (d2 != null)
                {
                    arr[2] = d2;
                }
                arr[0] = num % 10;
                num /= 10;
            }

            Console.WriteLine(arr[2] != null ? "Digit: " + arr[2] : "There is no such digit.");
        }
    }
}