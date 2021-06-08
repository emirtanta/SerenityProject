using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.BusinessLayer.Abstract
{
    public interface IMemberService
    {
        List<Member> GetList();

        Member GetByID(int id);

        void MemberInsert(Member member);
        void MemberUpdate(Member member);
        void MemberDelete(Member member);
       
    }
}
