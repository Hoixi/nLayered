using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrates
{
    public class Course : Entity<int>
    {
        public int categoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
