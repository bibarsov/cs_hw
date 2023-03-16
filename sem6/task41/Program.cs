/*
    Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
 */
namespace task41
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int result = 0;
            foreach (string num in nums.Split())
            {
                if (Convert.ToInt32(num.Trim()) > 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
