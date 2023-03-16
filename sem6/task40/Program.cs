/*
 На вход программы подаются три целых положительных числа. 
Определить , является ли это сторонами треугольника. 
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
является ли он прямоугольным, равнобедренным, равносторонним.

a + b > c => True
a + c > b => True
b + c > a => True
 */
namespace task40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = ReadInteger("Enter number 1:");
            int b = ReadInteger("Enter number 2:");
            int c = ReadInteger("Enter number 3:");

            if (IsTriangle(a, b, c))
            {
                Console.WriteLine("Given numbers represent a triangle.");
                double p = (a + b + c) / 2.0;
                Console.WriteLine("Area: {0}", Math.Sqrt(p* (p- a) *(p- b)*(p- c )));
                Console.WriteLine("Perimeter: {0}", a + b + c);
                double alpha = GetAngle(b, c, a);
                double gamma = GetAngle(a, c, b);
                double beta = GetAngle(a, b, c);
                Console.WriteLine("Angles: {0}, {1}, {2}", alpha, gamma, beta);
                Console.WriteLine("Is it right-angled triangle: {0}", c * c == a * a + b * b);
                Console.WriteLine("Is it isosceles triangle: {0}", alpha == gamma || alpha == beta || gamma == beta);
                Console.WriteLine("Is it equilateral triangle: {0}", a == b && b == c);
            }
            else
            {
                Console.WriteLine("Given numbers don't represent a triangle.");
            }
        }

        static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static double GetAngle(int a, int b, int c)
        {
            return Math.Round(Math.Acos((a * a + b * b - c * c) / (2.0 * a * b)) * 180.0 / Math.PI, 2);
        }

        static int[] GenerateArray(int len, int min, int maxExclusive)
        {
            int[] result = new int[len];
            Random randomizer = new Random();
            for (int i = 0; i < len; i++)
            {
                result[i] = randomizer.Next(min, maxExclusive);
            }
            return result;
        }

        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
