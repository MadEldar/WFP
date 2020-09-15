namespace Product_Service.Migrations
{
    using Product_Service.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Product_Service.Data.Product_Service_API_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Product_Service.Data.Product_Service_API_Context context)
        {
            context.Categories.AddOrUpdate(
                x => x.Id,
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Clothes" },
                new Category { Id = 3, Name = "Books" },
                new Category { Id = 4, Name = "Pet Supplies" }
            );

            context.Products.AddOrUpdate(
                x => x.Id,
                new Product { Id = 1, Name = "Chocolate", Description = "Chocolate is yummy", Price = (decimal)6.99, Stocks = 420 },
                new Product { Id = 2, Name = "Ice cream", Description = "Ice cream is yummy", Price = (decimal)4.20, Stocks = 69 },
                new Product { Id = 3, Name = "Pop tart", Description = "Pop tart is yummy", Price = (decimal)3.50, Stocks = 120 },
                new Product { Id = 4, Name = "T-shirt", Description = "T-shirt is not yummy", Price = (decimal)15.99, Stocks = 24 },
                new Product { Id = 5, Name = "Jeans", Description = "Jeans is not yummy", Price = (decimal)12.99, Stocks = 57 },
                new Product { Id = 6, Name = "Palladin", Description = "Palladin is a fantasy novel by Sally Slater", Price = (decimal)22.49, Stocks = 47 },
                new Product { Id = 7, Name = "Threads", Description = "Threads is a fantasy novel by Erin LaTimer", Price = (decimal)17.45, Stocks = 34 },
                new Product { Id = 8, Name = "A Touch of Poison", Description = "A Touch of Poison is a fantasy by Aaron Kite", Price = (decimal)12.30, Stocks = 76 },
                new Product { Id = 9, Name = "Pet food", Description = "Pet food is yummy for dogs", Price = (decimal)5.40, Stocks = 84 },
                new Product { Id = 10, Name = "Collar", Description = "Collar is cute", Price = (decimal)12.20, Stocks = 62 }
            );
        }
    }
}
