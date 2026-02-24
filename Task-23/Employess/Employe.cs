using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23.Employess
{
    internal class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }
}
