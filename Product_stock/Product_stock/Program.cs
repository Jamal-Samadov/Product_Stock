using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryID =1, CategoryName= "Komputer"},
                new Category {CategoryID = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProdcutId = 1, CategoryID = 1, Name = "Asus", Price= 1500, StockId=10},
                new Product{ProdcutId = 1, CategoryID = 2, Name = "Lenovo", Price= 1100, StockId=5},
                new Product{ProdcutId = 1, CategoryID = 3, Name = "Acer", Price= 900, StockId=26},
                new Product{ProdcutId = 1, CategoryID = 4, Name = "Dell", Price= 1700, StockId=20},
                new Product{ProdcutId = 1, CategoryID = 5, Name = "Macbook", Price= 2200, StockId=13},
                new Product{ProdcutId = 1, CategoryID = 6, Name = "Legion", Price= 1900, StockId=4},
            };


            

        }

        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(x => x.Price > 1200 && x.StockId > 10).ToList();
        }

        class Product
        {
            public int ProdcutId { get; set; }
            public int CategoryID { get; set; }
            public string Name { get; set; }
            public int StockId { get; set; }
            public int Price { get; set; }
        }

        class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }

    }
}
