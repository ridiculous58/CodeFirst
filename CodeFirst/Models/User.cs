using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
