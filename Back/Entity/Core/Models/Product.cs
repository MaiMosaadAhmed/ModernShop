using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core.Models
{
    public class Product : EntityId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Stock> Items { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}