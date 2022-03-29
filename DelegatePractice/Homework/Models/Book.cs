using Homework.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, string authorName, int pageCount) : base(name, price)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            if(Count > 0)
            {
                Count--;
                TotalInCome += Price;
                return;
            }

            throw new ProductCountIsZeroException("mehsulun sayi sifirdir");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Price: {Price} - Count: {Count} - TotalInCome: {TotalInCome} - AuthorName: {AuthorName}");
        }
    }
}
