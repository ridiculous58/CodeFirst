using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }
    }
}
