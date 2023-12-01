using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book: IPrintable
    {
        internal required int Id { get; set; }
        internal required string Name { get; set; }
        internal required Author Author { get; set; }
        internal required DateOnly publishDate { get; set; }

        internal Member? Borrower { get; set; }

        public override string ToString()
        {
            var result = $"Book: {Id} {Name} {Author.ToString()} {publishDate.ToShortDateString()}\nBorrower: ";
            if (Borrower != null)
            {
                result += $"{Borrower.ToString()}";
            } else
            {
                result += "None";
            }

            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
