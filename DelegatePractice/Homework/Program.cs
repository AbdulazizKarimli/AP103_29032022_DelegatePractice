using Homework.Exceptions;
using Homework.Models;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("test1", 34, "test testov", 40)
            {
                Count = 5
            };
            Book book2 = new Book("test2", 35, "tes1t testov", 45);

            Library library = new Library(2);

            try
            {
                library.AddBook(book1);
                library.AddBook(book2);
                //library.GetBookById(3);
                //library.RemoveById(4);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //foreach (var item in library.GetAllBooks())
            //{
            //    item.ShowInfo();
            //}

            //book1.ShowInfo();
            //book1.Sell();
            //book1.Sell();
            //book1.ShowInfo();
        }
    }
}
