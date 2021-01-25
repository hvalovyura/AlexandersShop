using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Interfaces;
using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDBContent db;
        private readonly IAllProducts _products;
        private readonly IProductsCategory _categories;
        private readonly IWebHostEnvironment _environment;

        public MessageController(IAllProducts products,
            IProductsCategory categories,
            AppDBContent content,
            IWebHostEnvironment environment)
        {
            db = content;
            _products = products;
            _categories = categories;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult CompareMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CompareMessage(Message message)
        {
            db.Messages.Add(message);
            db.SaveChanges();
            ViewBag.String = "Сообщение отправлено.";
            return View();
        }

        public IActionResult ShowMessages()
        {
            IEnumerable<Message> messages = null;

            var messagesObj = new MessageViewModel
            {
                AllMessages = db.Messages
            };

            return View(messagesObj);
        }

        [HttpPost]
        public IActionResult RemoveMessage(int? id)
        {
            db.Messages.Remove(db.Messages.Where(m => m.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("ShowMessages");
        }
    }
}
