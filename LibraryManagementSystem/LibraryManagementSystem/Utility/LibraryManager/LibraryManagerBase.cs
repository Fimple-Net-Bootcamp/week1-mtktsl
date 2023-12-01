using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utility.LibraryManagerResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility
{
    internal abstract class LibraryManagerBase : ILibraryManager
    {
        protected IMemberStore _memberStore;
        protected IBookStore _bookStore;

        protected List<BorrowInfo> _borrowInfos = new();

        internal LibraryManagerBase(IMemberStore memberStore, IBookStore bookStore)
        {
            _memberStore = memberStore;
            _bookStore = bookStore;
        }

        internal abstract void PrintTitle();

        internal virtual void PrintMembers()
        {
            _memberStore.Print();
        }

        internal virtual void PrintBooks()
        {
            _bookStore.Print();
        }

        public virtual BorrowBookResult BorrowBookForMemberNumber(int memberNumber, int bookId, DateOnly borrowDate, DateOnly expireDate)
        {
            if (_bookStore.GetBookById(bookId) == null)
            {
                return BorrowBookResult.InvalidBookId;
            }

            if (_memberStore.GetMemberByMemberNumber(memberNumber) == null)
            {
                return BorrowBookResult.InvalidMemberNumber;
            }

            if (_borrowInfos.FirstOrDefault(info => info.BookId == bookId) != null)
            {
                return BorrowBookResult.AlreadyBorrowedBookId;
            }

            _borrowInfos.Add(
                new BorrowInfo
                {
                    BookId = bookId,
                    MemberNumber = memberNumber,
                    BorrowDate = borrowDate,
                    ExpireDate = expireDate
                }
            );

            return BorrowBookResult.Success;
        }

        public virtual RegisterBookResult RegisterBook(Book newBook)
        {
            switch (_bookStore.AddBook(newBook))
            {
                case BookStoreResult.BookAddingResult.Success:
                    return RegisterBookResult.Success;

                case BookStoreResult.BookAddingResult.DuplicateName:
                    return RegisterBookResult.DuplicateBookName;

                case BookStoreResult.BookAddingResult.DuplicateId:
                    return RegisterBookResult.DuplicateBookId;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public virtual RegisterMemberResult RegisterMember(Member newMember)
        {
            switch (_memberStore.AddMember(newMember))
            {
                case MemberStoreResult.MemberAddingResult.Success:
                    return RegisterMemberResult.Success;
                
                case MemberStoreResult.MemberAddingResult.DuplicateNumber:
                    return RegisterMemberResult.DuplicateMemberNumber;
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public virtual ReturnBookResult ReturnBook(int bookId, DateOnly returnDate)
        {
            return
                _borrowInfos.RemoveAll(info => info.BookId == bookId) > 0
                ? ReturnBookResult.Success
                : ReturnBookResult.NotYetBorrowedBookId;
        }

        public virtual UnregisterBookResult UnregisterBookById(int id)
        {
            switch (_bookStore.RemoveBookById(id))
            {
                case BookStoreResult.BookDeletionResult.Success:
                    return UnregisterBookResult.Success;

                case BookStoreResult.BookDeletionResult.InvalidId:
                    return UnregisterBookResult.InvalidBookId;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public virtual UnregisterMemberResult UnregisterMemberByMemberNumber(int memberNumber)
        {
            switch (_memberStore.RemoveMemberByMemberNumber(memberNumber))
            {
                case MemberStoreResult.MemberRemovalResult.Success:
                    return UnregisterMemberResult.Success;

                case MemberStoreResult.MemberRemovalResult.InvalidNumber:
                    return UnregisterMemberResult.InvalidMemberNumber;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
