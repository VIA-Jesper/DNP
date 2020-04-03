using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dotnetimals.Entities;

namespace Dotnetimals.Data
{
    public static class DBInitializer

    {
        public static void Initialize(CatContext context)
        {
            Debug.WriteLine("Ensuring db");
            context.Database.EnsureCreated();

            // Look for any
            if (context.Cats.Any())
            {
                return; // DB has been seeded
            }

            var cats = new Cat[]
            {
                new Cat()
                {
                    Name = "Trigger", Price = 42, Color = "Black", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Tiger", Price = 53, Color = "Black and White", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Max", Price = 24, Color = "Grey", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Smokey", Price = 36, Color = "ShallowRed", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Sam", Price = 57, Color = "CrimsonBlack", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Kitty", Price = 37, Color = "DarkGrey", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Sassy", Price = 29, Color = "MultiredBlack", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                },
                new Cat()
                {
                    Name = "Shadow", Price = 31, Color = "White", FavoriteDish = "KittyFood",
                    Birthday = new DateTime(2010, 03, 03)
                }
            };

            foreach (var cat in cats)
            {
                context.Cats.Add(cat);
            }

            context.SaveChanges();

        }
    }
}
