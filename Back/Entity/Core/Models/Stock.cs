using Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Core.Models
{
    public class Stock : EntityId
    {
        public string Color { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}