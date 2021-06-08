using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityProject.EntityLayer.Entities
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

       
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(500)]
        public string Adress { get; set; }
    }
}
