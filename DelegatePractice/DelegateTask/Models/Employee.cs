using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Models
{
    internal class Employee : Person
    {
        public double Salary { get; set; }
        public string Email { get; set; }

        public Employee(string name, string surname, byte age, double salary, string email) : base(name, surname, age)
        {
            Salary = salary;
            Email = email;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Email: {Email} - Salary: {Salary}");
        }
    }
}
