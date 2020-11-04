using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }
        public IEnumerable<Category> AllCategories { get; set; }
        public string CurrentCategory { get; set; }
    }
}
