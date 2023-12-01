using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Utility
{
    internal interface IMemberStore: IPrintable
    {
        MemberStoreResult.MemberAddingResult AddMember(Member newMember);
        MemberStoreResult.MemberRemovalResult RemoveMemberByMemberNumber(int memberNumber);
        
        Member? GetMemberByMemberNumber(int memberNumber);
    }
}
