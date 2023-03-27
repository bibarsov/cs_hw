/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */
namespace task60
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ReadInteger("Enter x:");
            int y = ReadInteger("Enter y:");
            int z = ReadInteger("Enter z:");

            int[,,] arr = GenerateThreeDimArray(x, y, z);
            PrintThreeDimArray(arr);
        }

        static int[,,] GenerateThreeDimArray(int x, int y, int z)
        {
            int[,,] result = new int[x, y, z];
            var set = new HashSet<int>();
            Random randomizer = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < result.GetLength(2); k++)
                    {
                        bool exists = true;
                        while (exists)
                        {
                            exists = true;
                            int random = randomizer.Next(10, 100);
                            if (!set.Contains(random))
                            {
                                result[i, j, k] = random;
                                exists = false;
                            }
                            set.Add(random);
                        }
                    }
                }
            }
            return result;
        }

        static void PrintThreeDimArray<T>(T[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0}({1},{2},{3}) ", arr[i, j, k],i,j,k);
                    }
                    Console.WriteLine();
                }
            }
        }
        static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
