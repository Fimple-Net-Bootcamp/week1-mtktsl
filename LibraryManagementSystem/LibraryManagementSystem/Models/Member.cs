using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Member: IPrintable
    {
        internal required int MemberNumber { get; set; }
        internal required string Name { get; set; }
        internal required string Surname { get; set; }

        List<Book> BorrowedBooks { get; set; } = new();

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string result = $"{MemberNumber} {Name} {Surname}\nBorrowed books:\n";

            for (int i = 0; i < BorrowedBooks.Count; i++)
            {
                result += $"{i}. {BorrowedBooks[i].ToString()}\n";
            }

            return result;
        }
    }
}
