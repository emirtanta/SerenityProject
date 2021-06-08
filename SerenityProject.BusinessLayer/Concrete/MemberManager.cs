
using SerenityProject.BusinessLayer.Abstract;
using SerenityProject.DataAccessLayer.Abstract;
using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.BusinessLayer.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetList()
        {
            return _memberDal.List();
        }

        public Member GetByID(int id)
        {
            return _memberDal.Get(x=>x.Id==id);
        }

        public void MemberInsert(Member member)
        {
            _memberDal.Insert(member);
        }

        public void MemberUpdate(Member member)
        {
            _memberDal.Update(member);
        }

        public void MemberDelete(Member member)
        {
            _memberDal.Delete(member);
        }

        
        
    }
}
