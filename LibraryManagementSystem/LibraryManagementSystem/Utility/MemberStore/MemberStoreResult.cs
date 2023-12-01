using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility.MemberStoreResult
{
    internal enum MemberAddingResult
    {
        Success,
        DuplicateNumber
    }

    internal enum MemberRemovalResult
    {
        Success,
        InvalidNumber
    }
}
