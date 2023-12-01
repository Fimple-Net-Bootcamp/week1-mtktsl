using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility.MemberStoreResult;

namespace LibraryManagementSystem.Utility
{
    internal class MemberStore : IMemberStore
    {
        private List<Member> _members = new();
        public MemberAddingResult AddMember(Member newMember)
        {
            if (GetMemberByMemberNumber(newMember.MemberNumber) != null)
            {
                return MemberAddingResult.DuplicateNumber;
            }

            _members.Add(newMember);
            return MemberAddingResult.Success;
        }

        public Member? GetMemberByMemberNumber(int memberNumber)
        {
            return _members.FirstOrDefault(m => m.MemberNumber == memberNumber);
        }

        public void Print()
        {
            foreach (Member member in _members)
            {
                member.Print();
            }
        }

        public MemberRemovalResult RemoveMemberByMemberNumber(int memberNumber)
        {
            return
                _members.RemoveAll(m => m.MemberNumber == memberNumber) > 0
                ? MemberRemovalResult.Success
                : MemberRemovalResult.InvalidNumber;
        }
    }
}
