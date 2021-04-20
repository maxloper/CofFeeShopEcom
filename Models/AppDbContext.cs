using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CofFeeShop.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Coffee> Coffees { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Strong Coffees" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Medium Blend Coffees" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Coffees" });

            //seed pies

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId = 1,
                Name = "Home Blend Coffee",
                Price = 12.95M,
                ShortDescription = "Award-Winning Home Blend Coffee",
                LongDescription =
                    "Our Home Blend has a medium body which is complemented by deep red fruit acidity, cocoa sweetness and a pleasant lingering finish.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee

            {
                CoffeeId = 2,
                Name = "Red Blend Coffee",
                Price = 18.95M,
                ShortDescription = "little bit of luxury!",
                LongDescription =
                    "an aroma of sweet caramel",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = true,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId= 3,
                Name = "Colombian",
                Price = 18.95M,
                ShortDescription = "Pure blend",
                LongDescription =
                    "a really strong coffee with lots of body and flavour.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
               
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId = 4,
                Name = "HazelNut Coffee",
                Price = 15.95M,
                ShortDescription = "Delicious and tasty Hazelnut",
                LongDescription =
                    "If you like flavoured coffe this is for you",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
               
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId  = 5,
                Name = "Natural BURUI",
                Price = 13.95M,
                ShortDescription = "A natural processed coffee",
                LongDescription =
                    "A natural processed coffee whilst avoiding any negative over-fermented notes",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
               
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId = 6,
                Name = "Flora",
                Price = 17.95M,
                ShortDescription = "perfect for winter days",
                LongDescription =
                    "fudge-like sweetness and chocolate notes.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId = 7,
                Name = "Grace",
                Price = 15.95M,
                ShortDescription = "a coffee that really stand out",
                LongDescription =
                    "a long fermentation process that ramps up both the fruity characteristics",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                IsCoffeeOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                
            });

            modelBuilder.Entity<Coffee>().HasData(new Coffee
            {
                CoffeeId = 8,
                Name = "Vista",
                Price = 12.95M,
                ShortDescription = "a mix of bourbon varieties",
                LongDescription =
                    "The coffee is rounded with milk chocolate notes.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsCoffeeOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                
            });

           
        }




    }



}
