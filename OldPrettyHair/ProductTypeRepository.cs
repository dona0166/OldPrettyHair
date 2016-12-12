using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPrettyHair
{
    public class ProductTypeRepository
    {
        Dictionary<int, ProductType> products = new Dictionary<int, ProductType>();
        int newid = 0;
        ProductType result = null;
        public void GetNewId()
        {
            newid = products.Keys.Last() + 1;

        }
        public void AddProduct(int id_from_database, int id, string des, double p, int a)
        {
            products.Add(id_from_database, new ProductType(id, des, p, a));
            GetNewId();
            //key updated by database, product id updated by GetNewId()
            
        }
        public bool CheckProduct(int id)
        {
            
            if(products.ContainsKey(id) == true)
                return true;
            else
            {
                throw new Exception("Product not found");
            }
        }

        public ProductType GetProduct(int id)
        {
            if (CheckProduct(id) || products[id]!=null)
                return products[id];
            else
            {
                throw new Exception("Product not implemented");
            }
        }

        public double GetAmount(int id)
        {
            ProductType product_x = GetProduct(id);
            return product_x.Amount;
        }
    }
}
