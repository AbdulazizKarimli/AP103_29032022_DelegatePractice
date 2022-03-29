using Homework.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Library
    {
        private List<Book> _books;
        
        public int BookLimit { get; set; }

        public Library(int bookLimit)
        {
            _books = new List<Book>();
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new NullReferenceException("null ola bilmez");

            if(_books.Count < BookLimit)
            {
                _books.Add(book);
                return;
            }

            throw new CapacityLimitException("limit doldu...");
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            foreach (var book in _books)
            {
                if(book.Id == id)
                    return book;
            }

            return null;
        }
        public void RemoveById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            foreach (var book in _books)
            {
                if(book.Id == id)
                {
                    _books.Remove(book);
                    return;
                }
            }

            throw new NotFoundException($"bu {id} idli kitab tapilmadi");
        }
        public List<Book> GetAllBooks()
        {
            List<Book> booksCopy = new List<Book>();
            booksCopy.AddRange(_books);

            return booksCopy;
        }
    }
}
