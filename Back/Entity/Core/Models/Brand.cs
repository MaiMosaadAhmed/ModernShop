using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core.Models
{
    public class Brand : EntityId
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}