using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    abstract class Product
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome { get; protected set; }

        public Product(string name, double price)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
        }

        public abstract void ShowInfo();
        public abstract void Sell();
    }
}
