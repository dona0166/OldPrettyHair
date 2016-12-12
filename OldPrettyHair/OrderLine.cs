using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPrettyHair
{
    public class OrderLine
    {
        public ProductType Product { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        
        
        public OrderLine(ProductType p, Order o, int q)
        {
            this.Product.Id = p.Id;
            this.Order.Id = o.Id;
            this.Quantity = q;
        }
    }
}
