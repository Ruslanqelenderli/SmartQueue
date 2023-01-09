using System;
using System.Collections.Generic;
using System.Linq;
using SmartQueue.Entity.Entities.Common;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Entity.Entities
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HashedPassword { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
