using System;

namespace Local_Function_and_Static_Local_Function_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // AreaofCircle is the local function of the main function
            void AreaOfCircle (double a) {
            double ar;
            Console.WriteLine("Radius of the circle: " + a); 
            ar = 3.14 * a * a;
            Console.WriteLine("Area of circle: "+ ar);
            // Calling static local function
            Circumference(a);
                // Circumference is the Static local function 
                static void Circumference (double radii){ 
            double cr;
            cr  = 2 * 3.14 * radii;
            Console.WriteLine($"Circumference of the circle is: {cr:N2}");
        }
    }//end AreaOfCircle
    // Calling function
    AreaOfCircle(10);
    Console.ReadLine();

}//end Main


    }
}
