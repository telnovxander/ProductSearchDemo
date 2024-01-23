using Microsoft.EntityFrameworkCore;
using ProductSearchDemoApplication.Models;
using System;
using System.Linq;

namespace ProductSearchDemoApplication.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProductSearchDb;Trusted_Connection=True;");
        }

        public void SeedData() 
        {
            if (Products.Any())
            {
                return;
            }

            // Add test data
            Products.AddRange(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "top-view-tasty-muffin-with-forest-fruit-and-strawberries",
                    Description = "Delicious muffin with forest fruit and strawberries.",
                    ImagePath = "/Resources/top-view-tasty-muffin-with-forest-fruit-and-strawberries.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "top-view-biscuits-with-strawberry",
                    Description = "Biscuits with fresh strawberry topping.",
                    ImagePath = "/Resources/top-view-biscuits-with-strawberry.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "a-person-holding-fresh-baked-muffins-on-cooling-tray",
                    Description = "A person holding fresh baked muffins on a cooling tray.",
                    ImagePath = "/Resources/a-person-holding-fresh-baked-muffins-on-cooling-tray.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "close-up-still-life-of-pastries-on-table",
                    Description = "Close-up still life of pastries on the table.",
                    ImagePath = "/Resources/close-up-still-life-of-pastries-on-table.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "coconut-cheesecake-with-japanese-matcha-tea-white-chocolate-and-decorated-with-blackberries",
                    Description = "Coconut cheesecake with Japanese matcha tea, white chocolate, and decorated with blackberries.",
                    ImagePath = "/Resources/coconut-cheesecake-with-japanese-matcha-tea-white-chocolate-and-decorated-with-blackberries.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "front-view-view-tasty-cupcake-with-chocolate-and-chips",
                    Description = "Front view of a tasty cupcake with chocolate and chips.",
                    ImagePath = "/Resources/front-view-view-tasty-cupcake-with-chocolate-and-chips.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "fluffy-strawberry-swiss-roll-food-photography",
                    Description = "Fluffy strawberry Swiss roll in food photography.",
                    ImagePath = "/Resources/fluffy-strawberry-swiss-roll-food-photography.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "delicious-cake-with-whipping-cream-and-banana",
                    Description = "Delicious cake with whipping cream and banana.",
                    ImagePath = "/Resources/delicious-cake-with-whipping-cream-and-banana.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "set-of-confectionery-products-sweets-on-the-plate-zephyr-marmalade-biscuits-and-chocolate-sticks-top-view-stock-photo",
                    Description = "Set of confectionery products: sweets on the plate, zephyr, marmalade, biscuits, and chocolate sticks. Top view stock photo.",
                    ImagePath = "/Resources/set-of-confectionery-products-sweets-on-the-plate-zephyr-marmalade-biscuits-and-chocolate-sticks-top-view-stock-photo.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "cupcakes_23",
                    Description = "Cupcakes with colorful icing and toppings.",
                    ImagePath = "/Resources/cupcakes_23.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "delicious-cupcakes-with-candy-sprinkles",
                    Description = "Delicious cupcakes with candy sprinkles.",
                    ImagePath = "/Resources/delicious-cupcakes-with-candy-sprinkles.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "delicious-glazed-doughnuts-arrangement",
                    Description = "Delicious glazed doughnuts arrangement.",
                    ImagePath = "/Resources/delicious-glazed-doughnuts-arrangement.jpg"
                }
            );

            SaveChanges();
        }
    }
}
