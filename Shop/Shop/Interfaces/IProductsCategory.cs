using Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    public interface IProductsCategory
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
