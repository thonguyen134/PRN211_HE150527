using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        MemberDAO memberDAO = new MemberDAO();
        public void deleteMember(int id)
        {
            memberDAO.DeleteMemberById(id);
        }

        public IEnumerable<MemberObject> getMembers()
        {
            return memberDAO.GetMemberList();
        }

        public MemberObject GetMemberById(int id)
        {
            return memberDAO.GetMemBerById(id);
        }

        public void insertMember(MemberObject member)
        {
            memberDAO.InsertMember(member);
        }

        public void updateMember(MemberObject member)
        {
            memberDAO.UpdateMember(member);
        }

        public IEnumerable<MemberObject> getMemberById(int id)
        {
            return memberDAO.GetMemberById(id);
        }

        public IEnumerable<MemberObject> getMembersByName(string name)
        {
            return memberDAO.GetMemberByName(name);
        }
    }
}
