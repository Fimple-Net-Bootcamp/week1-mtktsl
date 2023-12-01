using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Author: IPrintable
    {
        internal required int Id { get; set; }
        internal required string Name { get; set; }
        internal required string Surname { get; set; }

        internal List<Book> Books { get; set; } = new();

        public override string ToString()
        {
            string result = $"{Id} {Name} {Surname}\nBooks:\n";

            for (int i = 0; i < Books.Count; i++)
            {
                result += $"{i+1}. {Books[i].ToString()}\n";
            }

            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
