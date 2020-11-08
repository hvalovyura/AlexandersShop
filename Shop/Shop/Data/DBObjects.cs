using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Product.Any())
            {
                content.AddRange
                    (
                        new Product
                        {
                            Name = "First",
                            Description = "First default product",
                            ImagePath = "/img/DefaultImage.jpg",
                            Category = Categories["Category1"]
                        },
                        new Product
                        {
                            Name = "Second",
                            Description = "Second default product",
                            ImagePath = "/img/DefaultImage.jpg",
                            Category = Categories["Category2"]
                        }
                    );
            }

            if(!content.Users.Any())
            {
                content.AddRange
                    (
                        new User
                        {
                            Login = "AlexSobol",
                            Password = "Password_For_Alex_Sobol_1"
                        }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Category1", Description = "First default category." },
                        new Category { Name = "Category2", Description = "Second default category." }
                    };

                    category = new Dictionary<string, Category>();
                    foreach(var element in list)
                    {
                        category.Add(element.Name, element);
                    }
                }
                return category;
            }
        }
    }
}
