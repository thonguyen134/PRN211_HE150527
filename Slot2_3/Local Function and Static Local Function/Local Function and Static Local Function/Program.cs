using System;

namespace Local_Function_and_Static_Local_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            void AddVaue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0} ", a + b + x + y);
                Console.WriteLine();
            }
            AddVaue(3, 4);
            AddVaue(5, 6);
            Console.ReadLine();
        }
    }
}
