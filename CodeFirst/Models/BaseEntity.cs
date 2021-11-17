using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    /// <summary>
    /// Database 
    /// </summary>
    public class BaseEntity 
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}
