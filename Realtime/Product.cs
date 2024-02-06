using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime
{
    internal class Product
    {
        List<String>Products = new List<String>() { "AA","BB","CC","DD"};
        public List<string>GetListOfProducts()
        {
            return Products;
        }
    }
}
