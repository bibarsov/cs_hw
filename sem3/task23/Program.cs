﻿/*
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
 */
namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (n > 0)
            {
                Console.Write(i * i * i);
                Console.Write(" ");
                i++;
                n--;
            }
        }
    }
}
