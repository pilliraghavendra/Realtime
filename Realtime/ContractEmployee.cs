﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime
{
    internal class ContractEmployee
    {
        Product Product=new Product();
        public  List<string> ShowOnlyContractEmp()
        {
            var totalListOfItems = Product.GetListOfProducts();
            return totalListOfItems.ToList();
        }

    }
}
