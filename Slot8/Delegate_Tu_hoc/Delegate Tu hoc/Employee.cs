using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Tu_hoc
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;
        private string position;

        public int Id { set; get; }
        public string Name { set; get; }
        public double Salary { set; get; }
        public string Position { set; get; }

        public Employee(int id, string name, double salary, string position)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.position = position;
        }
        public Employee()
        {
        }
        public void input()
        {
            Console.WriteLine("Enter ID:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose Position");
            Console.WriteLine("1:Manager 2:Dev 3:Tester 4:Other");
            int selectOption = 0;
            while (selectOption < 1 || selectOption > 4)
            {
                selectOption = Convert.ToInt32(Console.ReadLine());
                switch (selectOption)
                {
                    case 1:
                        Position = "Manager";
                        break;
                    case 2:
                        Position = "Dev";
                        break;
                    case 3:
                        Position = "Tester";
                        break;
                    case 4:
                        Position = "Other";
                        break;
                    default:
                        Console.WriteLine("Enter again!");
                        Console.WriteLine("1:Manager 2:Dev 3:Tester 4:Other");
                        break;
                }
            }
        }
        public delegate double SalaryCalculation(double salary, int x);
        public override string ToString()
        {
            return $"ID:{Id},Name:{Name},Salary:{Salary},Position:{Position}";
        }
        public void Display(SalaryCalculation delobj)
        {
            Console.WriteLine($"{ToString()}:Salary:{delobj}");
        }
       
            
    }
}
