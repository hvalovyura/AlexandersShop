using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class MessageViewModel
    {
        public IEnumerable<Message> AllMessages { get; set; }
    }
}
