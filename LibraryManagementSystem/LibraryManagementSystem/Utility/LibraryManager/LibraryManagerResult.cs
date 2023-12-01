using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility.LibraryManagerResult
{
    internal enum RegisterMemberResult
    {
        Success,
        DuplicateMemberNumber
    }

    internal enum UnregisterMemberResult
    {
        Success,
        InvalidMemberNumber
    }

    internal enum RegisterBookResult
    {
        Success,
        DuplicateBookId,
        DuplicateBookName
    }

    internal enum UnregisterBookResult
    {
        Success,
        InvalidBookId
    }

    internal enum BorrowBookResult
    {
        Success,
        InvalidMemberNumber,
        InvalidBookId,
        AlreadyBorrowedBookId
    }

    internal enum ReturnBookResult
    {
        Success,
        NotYetBorrowedBookId
    }
}
