using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        Product GetObjectProduct(int id);
    }
}
