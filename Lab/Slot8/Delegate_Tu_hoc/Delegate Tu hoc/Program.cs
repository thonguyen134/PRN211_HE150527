using System;
using System.Collections.Generic;
using static Delegate_Tu_hoc.Employee;

namespace Delegate_Tu_hoc
{
    public class Program
    {
        public static double Dev(double x, string y)
        {
            return x * 12;
        }
        static void Main(String[] args)
        {
            Employee e = new Employee();
            e.input();
            SalaryCalculation delobj;
            delobj = new SalaryCalculation((x, y) => x * y);
            Console.WriteLine($"salary:{delobj(20,1)}")

        }
        
    }
    
}
