using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class BProducto
    {
        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();
            
            products = DProduct.Get();

            return products;
        }
    }
}
