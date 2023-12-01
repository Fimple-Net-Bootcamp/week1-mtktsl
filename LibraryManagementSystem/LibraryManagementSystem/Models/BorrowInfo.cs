using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class BorrowInfo
    {
        internal required int MemberNumber { get; set; }
        internal required int BookId { get; set; }
        internal required DateOnly BorrowDate { get; set; }
        internal required DateOnly ExpireDate { get; set; }

        public override string ToString()
        {
            return $"{MemberNumber} {BookId} {BorrowDate.ToShortDateString()} {ExpireDate.ToShortDateString}";
        }
    }
}
