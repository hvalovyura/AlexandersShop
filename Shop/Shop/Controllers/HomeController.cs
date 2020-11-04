using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;
using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _products;
        private readonly IProductsCategory _categories;

        public HomeController(IAllProducts products, IProductsCategory categories)
        {
            _products = products;
            _categories = categories;
        }

        public ActionResult Index()
        {
            return Redirect("/List");
        }

        [Route("/List")]
        [Route("/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                products = _products.Products.OrderBy(i => i.Id);
            }
            else
            {
                products = _products.Products.Where(i => i.Category.Name.Equals(_category)).OrderBy(i => i.Id);
                currCategory = _category;
            }

            var productObj = new ProductsListViewModel
            {
                AllProducts = products,
                CurrentCategory = currCategory
            };

            return View(productObj);
        }
    }
}
