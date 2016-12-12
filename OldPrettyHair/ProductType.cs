using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPrettyHair
{
    public class ProductType
    {
        
        
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }


        public ProductType(int id, string description, double price, int amount)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
            this.Amount = amount;
        }

       
    }
}
