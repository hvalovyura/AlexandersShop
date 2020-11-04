using Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    public interface IAllProducts
    {
        public IEnumerable<Product> Products { get; }
        public Product GetObjectProduct(int id);
    }
}
