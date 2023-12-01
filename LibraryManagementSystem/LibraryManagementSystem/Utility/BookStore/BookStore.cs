using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility.BookStoreResult;

namespace LibraryManagementSystem.Utility
{
    internal class BookStore : IBookStore
    {
        private List<Book> _books = new List<Book>();

        public BookStore() { }

        public BookAddingResult AddBook(Book newBook)
        {
            if(GetBookById(newBook.Id) != null)
            {
                return BookAddingResult.DuplicateId;
            }
            
            if(GetBookByName(newBook.Name) != null)
            {
                return BookAddingResult.DuplicateName;
            }
            
            _books.Add(newBook);
            return BookAddingResult.Success;
        }

        public List<Book> GetBooksByAuthor(Author author)
        {
            return _books.FindAll(b => b.Author.Equals(author));
        }

        public Book? GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public Book? GetBookByName(string name)
        {
            return _books.FirstOrDefault(b => b.Name == name);
        }

        public BookDeletionResult RemoveBookById(int id)
        {
            return 
                _books.RemoveAll(b => b.Id == id) > 0
                ? BookDeletionResult.Success
                : BookDeletionResult.InvalidId;
        }

        public void Print()
        {
            for (int i = 0; i < _books.Count; i++)
            {
                _books[i].Print();
            }
        }
    }
}
