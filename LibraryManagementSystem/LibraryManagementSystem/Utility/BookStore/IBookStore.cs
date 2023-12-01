using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utility.BookStoreResult;

namespace LibraryManagementSystem.Utility
{
    internal interface IBookStore: IPrintable
    {
        BookAddingResult AddBook(Book newBook);
        BookDeletionResult RemoveBookById(int id);
        Book? GetBookById(int id);
        Book? GetBookByName(string name);
        List<Book> GetBooksByAuthor(Author author);
    }
}
