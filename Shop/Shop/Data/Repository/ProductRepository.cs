using Microsoft.EntityFrameworkCore;
using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDbContent;
        public ProductRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Product> Products => appDbContent.Product.Include(c => c.Category);

        public Product GetObjectProduct(int id) => appDbContent.Product.FirstOrDefault(p => p.Id == id);
    }
}
