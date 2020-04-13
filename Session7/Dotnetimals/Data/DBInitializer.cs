using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dotnetimals.Controllers;
using Dotnetimals.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace Dotnetimals.Data
{
    public static class DBInitializer

    {
        public static void Initialize(CatContext context)
        {
            Debug.WriteLine("Ensuring db");
            context.Database.EnsureCreated();

            // Look for any
            if (context.Cats.Any() && context.Orders.Any())
            {
                return; // DB has been seeded
            }

            if (!context.Cats.Any())
            {


                var cats = new Cat[]
                {
                    new Cat()
                    {
                        Name = "Trigger", Price = 42, Color = "Black", FavoriteDish = "KittyFood",
                        Birthday = new DateTime(2010, 03, 03)
                    },
                    new Cat()
                    {
                        Name = "Tiger", Price = 53, Color = "White", FavoriteDish = "KittyFood",
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
            
            if (!context.Orders.Any(x=>x.Id == 1))
            {

                List<Cat> cats = new List<Cat>
                {
                    context.Cats.Single(x => x.Id == 1),
                    context.Cats.Single(x => x.Id == 2)
                };

                
                var order = new Order()
                {
                    Id = 1,
                    OrderDate = DateTime.Now
                };
                
                
                context.Orders.Add(order);
                context.SaveChanges();

                var orderItem = new OrderItem()
                {
                    Order = order,
                    Cat = cats[0]
                };

                context.Add(orderItem);
                
                var orderItem2 = new OrderItem()
                {
                    Order = order,
                    Cat = cats[1]
                };

                context.Add(orderItem2);




                context.SaveChanges();



            }


            
        }
    }
}
