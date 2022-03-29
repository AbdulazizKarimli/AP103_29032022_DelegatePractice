using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Models
{
    abstract class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person(string name, string surname, byte age)
        {
            _id++;
            Id = _id;
            Name = name;
            Age = age;
            Surname = surname;
        }

        public abstract void ShowInfo();
    }
}
