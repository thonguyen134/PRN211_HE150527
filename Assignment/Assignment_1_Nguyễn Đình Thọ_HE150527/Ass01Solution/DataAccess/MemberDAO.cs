using BusinessObject;
using System;
using System.Linq;
using System.Collections.Generic;
namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> listMember = new List<MemberObject>
        {
            new MemberObject(){MemberID=1,MemberName="ThoNguyen",Email="thondhe150527@fpt.edu.vn",
            Password="123",City="Ha Noi",Country="Viet Nam"
            },
            new MemberObject(){MemberID=2,MemberName="NamBeo",Email="nampxhHE150000@fpt.edu.vn",
            Password="123",City="Ha Noi",Country="Viet Nam"
            },
            new MemberObject(){MemberID=3,MemberName="BinhChinh",Email="binhnhHE151500@fpt.edu.vn",
            Password="123",City="Ha Noi",Country="Viet Nam"
            }
        };

        public MemberDAO()
        {
        }
        public List<MemberObject> GetMemberList()
        {
            return listMember;
        }
        public List<MemberObject> GetMemberById(int id)
        {
            return listMember.Where(MemberObject => id == MemberObject.MemberID).ToList();
        }
        public List<MemberObject> GetMemberByName(string name)
        {
            return listMember.Where(x => x.MemberName.ToLower().Contains(name.ToLower())).ToList();
        }
        public MemberObject GetMemBerById(int id)
        {
            MemberObject memberObject = listMember.SingleOrDefault(a => a.MemberID == id);
                return memberObject;
        }
        public void InsertMember(MemberObject member)
        {
            MemberObject memberObject = GetMemBerById(member.MemberID);
            if (memberObject == null)
            {
                listMember.Add(member);
            }
            else
            {
                throw new Exception("Member ID alrealy exists.");
            }
            
        }
        public void UpdateMember(MemberObject member)
        {
            MemberObject memberObject = GetMemBerById(member.MemberID);
            if (memberObject != null)
            {
                var index = listMember.IndexOf(memberObject);
                listMember[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public void DeleteMemberById(int id)
        {
            MemberObject memberObject = GetMemBerById(id);
            if (memberObject != null)
            {
                listMember.Remove(memberObject);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
    }
}
