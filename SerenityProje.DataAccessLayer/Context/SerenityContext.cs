using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.DataAccessLayer.Context
{
    public class SerenityContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
