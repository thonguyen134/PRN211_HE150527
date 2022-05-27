using System;

namespace Passing_Parameters_with_ref__out_and_params_2
{
    internal class Program
    {
        static void SumArray(out int s, params int[] list)
        {

            int i;

            s = 0;

            for (i = 0; i < list.Length; i++)
            {
                s += list[i];

            }

        }
        static void Main(string[] args)
        {

            int s;

            SumArray(out s, 1, 2, 3, 4);

            Console.WriteLine($"s={s}");

            int[] myIntArray = { 5, 6, 7, 8, 9 };

            SumArray(out s, myIntArray);

            Console.WriteLine($"s={s}");

            SumArray(out s);

            Console.WriteLine($"s={s}");

            Console.ReadLine();

        }
    }
}