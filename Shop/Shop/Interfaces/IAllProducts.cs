using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    interface IAllProducts
    {
        IEnumerable<Product> Products { get; set; }
        Product GetObjectProduct(int id);
    }
}
