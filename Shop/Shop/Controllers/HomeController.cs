﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Interfaces;
using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _products;
        private readonly IProductsCategory _categories;
        private readonly AppDBContent _content;
        private readonly IWebHostEnvironment _environment;

        public HomeController(IAllProducts products,
            IProductsCategory categories,
            AppDBContent content,
            IWebHostEnvironment environment
            )
        {
            _products = products;
            _categories = categories;
            _content = content;
            _environment = environment;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        [Route("/List")]
        public ActionResult List()
        {
            ViewBag.String = "Все товары.";

            var productObj = new ProductsListViewModel
            {
                AllProducts = _products.Products.OrderBy(i => i.Id),
                AllCategories = _categories.AllCategories.OrderBy(o => o.Id)
            };

            return View(productObj);
        }

        [Route("/ProductPage/{id}")]
        public ActionResult ProductPage(int id)
        {
            IEnumerable<Product> products = null;
            Product product = _products.Products.Where(o => o.Id == id).FirstOrDefault();
            products = _products.Products.Where(o => o.Id == id);
            var productObj = new ProductsListViewModel
            {
                AllProducts = products,
                AllCategories = _categories.AllCategories,
                CurrentCategory = ""
            };

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
        public ActionResult CreateProduct(Product product, int categoryId, IFormFile uploadedFile)
        {
            string path = $"/img/{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
            using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.CreateNew))
            {
                uploadedFile.CopyTo(fileStream);
            }
            product.Category = _categories.AllCategories.Where(x => x.Id == categoryId).FirstOrDefault();
            product.ImagePath = $"{path}";
            _content.Product.Add(product);
            _content.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            var productObj = new ProductsListViewModel
            {
                AllProducts = _products.Products,
                AllCategories = _categories.AllCategories,
                CurrentCategory = ""
            };
            return View(productObj);
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            _content.Category.Add(category);
            _content.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult RemoveProduct(int? id)
        {
            _content.Product.Remove(_content.Product.Where(el => el.Id == id).FirstOrDefault());
            _content.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult RemoveCategory(int? id)
        {
            foreach (var element in _content.Product.Where(el => el.Category.Id == id))
            {
                _content.Product.Remove(element);
            }
            _content.SaveChanges();
            _content.Category.Remove(_content.Category.Where(el => el.Id == id).FirstOrDefault());            
            _content.SaveChanges();
            return RedirectToAction("List");
        }

        
    }
}
