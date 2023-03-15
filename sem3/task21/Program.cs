/*
    Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
 */
namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPoint = RequireNotNull(Console.ReadLine());
            string secondPoint = RequireNotNull(Console.ReadLine());
            string[] fpItems = firstPoint.Split(" ");
            string[] spItems = secondPoint.Split(" ");

            int x1 = Convert.ToInt32(fpItems[0]);
            int y1 = Convert.ToInt32(fpItems[1]);
            int z1 = Convert.ToInt32(fpItems[2]);

            int x2 = Convert.ToInt32(spItems[0]);
            int y2 = Convert.ToInt32(spItems[1]);
            int z2 = Convert.ToInt32(spItems[2]);

            Console.WriteLine(Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2));
        }

        //helper methods
        static T RequireNotNull<T>(T o)
        {
            if (o == null)
            {
                throw new ArgumentNullException();
            }
            return o;
        }
    }
}
