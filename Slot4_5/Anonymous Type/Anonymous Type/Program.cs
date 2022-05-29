using System;

namespace Anonymous_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new { id = 1000, name = "jack" };
            Console.WriteLine($"id:{obj1.id},name:{obj1.name}");

            dynamic obj2 = new { id = 2000, name = "scott", Email = "scott@gmail.com" };
            Console.WriteLine($"id:{obj2.id},name:{obj2.name},Email:{obj2.Email}");
        }
    }
}
