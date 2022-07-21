using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Gross Pay(IDR): ");
            decimal action = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The net pay is: " + Salary.Salary_calculate(action) + " IDR");
        }
    }
}