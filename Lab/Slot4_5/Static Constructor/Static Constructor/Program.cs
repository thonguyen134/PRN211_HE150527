using System;

namespace Static_Constructor
{
    class MyClass { 
    public static int x = 1;
    static MyClass()
    {
        x = 2;
        Console.WriteLine("Static contructor : x = {0} ", x);
    }
    public MyClass()
    {
        x++;
        Console.WriteLine("Object constructor : x ={0}", x);
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            MyClass.x = 4;
            MyClass m2 = new MyClass();
        }
    }
}
