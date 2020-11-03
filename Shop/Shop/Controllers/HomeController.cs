using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _products;
        private readonly IAllProducts _categories;

        public HomeController(IAllProducts products, IAllProducts categories)
        {
            _products = products;
            _categories = categories;
        }

        public ViewResult Index()
        {
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.AllProducts = _products.Products;
            obj.CurrentCategory = "Category1";
            return View(obj);
        }
    }
}
