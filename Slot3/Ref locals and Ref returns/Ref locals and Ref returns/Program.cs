using System;

namespace Ref_locals_and_Ref_returns
{
    internal class Program
    {

        static int[] numbers = { 1, 2, 3, 4, 5 };
        static ref int FindNumber(int target)
        {
            bool flag = true;

            ref int value = ref numbers[0];

            for (int ctr = 0; ctr < numbers.Length && flag == true; ctr++)
            {
                if (numbers[ctr] == target)
                {

                    value = ref numbers[ctr];

                    flag = false;
                }
            }
            return ref value;
        }
            static void Main(string[] args)
            {
                Console.Write("Original sequence:"); 
                Console.WriteLine(string.Join(" ",numbers)); 
               ref int value = ref FindNumber (3); 
                value *= 2; Console.Write("New sequence: "); 
                Console.WriteLine(string. Join(" ", numbers)); 
                Console.ReadLine(); }
        }//end Main 
         //end Program
}
