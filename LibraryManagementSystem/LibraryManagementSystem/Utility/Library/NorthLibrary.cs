using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Utility.Library
{
    internal class NorthLibrary : LibraryManagerBase
    {
        internal static string libraryName = "NorthLibrary";

        private void GenerateMembers()
        {
            var member1 = new Member
            {
                MemberNumber = 0,
                Name = "Kadir",
                Surname = "Kaya"
            };

            var member2 = new Member
            {
                MemberNumber = 1,
                Name = "Selin",
                Surname = "Yılmaz"
            };

            var member3 = new Member
            {
                MemberNumber = 2,
                Name = "Mehmet",
                Surname = "Özdemir"
            };

            var member4 = new Member
            {
                MemberNumber = 3,
                Name = "Ege",
                Surname = "Öztürk"
            };

            var member5 = new Member
            {
                MemberNumber = 4,
                Name = "Merve",
                Surname = "Şahin"
            };

            RegisterMember(member1);
            RegisterMember(member2); 
            RegisterMember(member3); 
            RegisterMember(member4);
            RegisterMember(member5);
        }


        private void GenerateBooks()
        {
            Author author1 = new Author { 
                Id = 0, 
                Name = "Yusuf", 
                Surname = "Kılıç",
            };

            Author author2 = new Author
            {
                Id = 0,
                Name = "Yusuf",
                Surname = "Kılıç",
            };

            Author author3 = new Author
            {
                Id = 0,
                Name = "Yusuf",
                Surname = "Kılıç",
            };

            var book1 = new Book
            {
                Id = 1,
                Author = author1,
                Name = "The Secret of the Lost City",
                publishDate = new DateOnly(2001, 1, 5)
            };

            var book2 = new Book
            {
                Id = 2,
                Author = author1,
                Name = "The Last of the Dragons",
                publishDate = new DateOnly(2011, 6, 1)
            };

            var book3 = new Book
            {
                Id = 3,
                Author = author2,
                Name = "The Curse of the Dark Forest",
                publishDate = new DateOnly(2003, 3, 7)
            };

            var book4 = new Book
            {
                Id = 4,
                Author = author2,
                Name = "The Mystery of the Haunted Mansion",
                publishDate = new DateOnly(2006, 2, 4)
            };

            var book5 = new Book
            {
                Id = 5,
                Author = author3,
                Name = "The Quest for the Golden Key",
                publishDate = new DateOnly(2005, 9, 9)
            };

            author1.Books.Add(book1);
            author1.Books.Add(book2);

            author2.Books.Add(book3);
            author2.Books.Add(book4);

            author3.Books.Add(book5);

            RegisterBook(book1);
            RegisterBook(book2);
            RegisterBook(book3);
            RegisterBook(book4);
            RegisterBook(book5);
        }

        public NorthLibrary(IMemberStore memberStore, IBookStore bookStore) : base(memberStore, bookStore)
        {
            GenerateMembers();
            GenerateBooks();
        }

        internal override void PrintTitle()
        {
            Console.WriteLine($"Welcome to {libraryName}");
        }

        internal override void PrintBooks()
        {
            Console.WriteLine($"Registered Books in {libraryName}");
            base.PrintBooks();
        }

        internal override void PrintMembers()
        {
            Console.WriteLine($"Registered Members in {libraryName}");
            base.PrintMembers();
        }
    }
}
