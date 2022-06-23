using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> getMembers();
        IEnumerable<MemberObject> getMemberById(int id);
        IEnumerable<MemberObject> getMembersByName(string name);
        MemberObject GetMemberById(int id);
        void insertMember(MemberObject member);
        void updateMember(MemberObject member);
        void deleteMember(int id);
    }
}
