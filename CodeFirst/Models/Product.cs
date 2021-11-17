using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
