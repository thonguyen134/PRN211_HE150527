using System;

namespace OOP_Encapsulation
{
    class Customer
    {
        private int Id;
        public int CustomerID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID:{CustomerID},Name: {CustomerName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.CustomerID = 1000;
            Console.WriteLine($"ID:{obj.CustomerID}, Name:{obj.CustomerName}");
            obj.CustomerID = 2000;
            obj.CustomerName = "Jack";
            obj.Print();
            Console.ReadLine();
        }
    }
}
