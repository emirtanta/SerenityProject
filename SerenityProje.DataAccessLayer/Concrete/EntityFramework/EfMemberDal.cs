using SerenityProject.DataAccessLayer.Abstract;
using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfMemberDal:EfGenericRepository<Member>,IMemberDal
    {
    }
}
