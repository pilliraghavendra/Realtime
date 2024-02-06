using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime
{
    internal class Parminent
    {
        Product Product = new Product();
        public List<string> ShowOnlyPeminentEmp()
        {
            var totalListOfItems = Product.GetListOfProducts();
            return totalListOfItems.ToList();
        }
    }
}
