using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utility.LibraryManagerResult;

namespace LibraryManagementSystem.Utility
{
    internal interface ILibraryManager
    {
        RegisterMemberResult RegisterMember(Member newMember);
        UnregisterMemberResult UnregisterMemberByMemberNumber(int memberNumber);
        RegisterBookResult RegisterBook(Book newBook);
        UnregisterBookResult UnregisterBookById(int id);

        BorrowBookResult BorrowBookForMemberNumber(int memberNumber, int bookId, DateOnly borrowDate, DateOnly expireDate);
        ReturnBookResult ReturnBook(int bookId, DateOnly returnDate);
    }
}
