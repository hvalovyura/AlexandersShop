using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data;
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
        private readonly AppDBContent _content;

        public HomeController(IAllProducts products, IProductsCategory categories, AppDBContent content)
        {
            _products = products;
            _categories = categories;
            _content = content;
        }

        public ActionResult Index()
        {
            return Redirect("/List");
        }

        [Route("/List")]
        [Route("/List/{category}")]
        public ActionResult List(string category, string searchString)
        {
            ViewBag.String = "Все товары.";
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                products = _products.Products.OrderBy(i => i.Id);
            }
            else
            {
                ViewBag.String = $" Категория - {category}. ";
                products = _products.Products.Where(i => i.Category.Name.Equals(_category)).OrderBy(i => i.Id);
                currCategory = _category;
            }

            var productObj = new ProductsListViewModel
            {
                AllProducts = products,
                AllCategories = _categories.AllCategories,
                CurrentCategory = currCategory
            };
            if(!string.IsNullOrEmpty(searchString))
            {
                ViewBag.String += $" Поиск по запросу \"{searchString}\"";
                productObj.AllProducts = productObj.AllProducts.Where(x => x.Name.ToLower().Contains(searchString.ToLower()));
                ViewBag.String += productObj.AllProducts.Count() == 0 ? "не дал результатов." : ".";
            }

            return View(productObj);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            var productObj = new ProductsListViewModel
            {
                AllProducts = _products.Products,
                AllCategories = _categories.AllCategories,
                CurrentCategory = ""
            };
            SelectList cat = new SelectList(_content.Category, "Id", "Name");
            ViewBag.Categories = cat;
            return View(productObj);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product, int categoryId)
        {
            product.Category = _categories.AllCategories.Where(x => x.Id == categoryId).FirstOrDefault();
            _content.Product.Add(product);
            _content.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
