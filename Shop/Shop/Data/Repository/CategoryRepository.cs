using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {
        private readonly AppDBContent appDbContent;
        public CategoryRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
