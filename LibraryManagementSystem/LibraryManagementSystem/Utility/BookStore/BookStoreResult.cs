using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility.BookStoreResult
{
    internal enum BookAddingResult
    {
        Success,
        DuplicateId,
        DuplicateName
    }
    internal enum BookDeletionResult
    {
        Success,
        InvalidId
    }
}
