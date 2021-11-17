using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Employee  : BaseEntity
    {
        [ForeignKey("User")]
        public override int Id { get => base.Id; set => base.Id = value; }
        public virtual User User { get; set; }
    }
}
