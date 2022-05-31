using System;

namespace Generic_Methods
{
    public class MyClass
    {
        // Generics method with two types T and U
        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        } }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of MyClass
            MyClass obj = new MyClass();

            // Calling Generics method
            obj.Display<string, int>("Integer", 2050);
            obj.Display<double, char>(155.9, 'A');
            obj.Display<float, double>(358.9F, 255.67);
            Console.ReadLine();
        }
    } 
}
