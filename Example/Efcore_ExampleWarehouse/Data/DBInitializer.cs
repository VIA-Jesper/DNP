using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using Efcore_ExampleWarehouse.Entities.example;
using Microsoft.EntityFrameworkCore;

namespace Efcore_ExampleWarehouse.Data
{
    public static class DBInitializer

    {
        public static void Initialize(CatContext context)
        {
            Debug.WriteLine("Ensuring db");
            context.Database.EnsureCreated();
            if (context.Warehouses.ToList().Any()) return;
            //// Look for any
            //if (!context.Warehouses.Any() && !context.Clients.Any() && !context.Locations.Any() && !context.Pallets.Any())
            //{
            //    Debug.Write("Database has already been seeded...");
            //    return; // DB has been seeded
            //}
            //else
            //{


            var clients = new List<Client>()
            {
                new Client()
                {
                    Username = "1",
                    Name = "1"
                }
            };
            context.Clients.AddRange(clients);
            var warehouses = new Warehouse[]
            {
                new Warehouse()
                {
                    Address = "1",
                    Name = "1",
                    UnitPrice = 11,


                },
                new Warehouse()
                {
                    Address = "2",
                    Name = "2",
                    UnitPrice = 11

                }
            };


            var locations = new List<Location>()
            {
                new Location()
                {
                    Position = "pos1"
                },
                new Location()
                {
                    Position = "pos2"
                },
                //new Location()
                //{
                //    Position = "pos1"
                //}
            };
            warehouses[0].Locations = locations;
            context.Warehouses.AddRange(warehouses);
            context.SaveChanges();
            Console.WriteLine("Database has been seeded with warehouse, client, locations.");
            // get warehouse and check locations.

            var tmpWarehouse = context.Warehouses.ToList();
            var debugLine = "";


            // try add a location to warehouse
            var ware = context.Warehouses.ToList()[0];
            ware.Locations.Add(new Location() {Position = "pos3"});
            context.Warehouses.Update(ware);
            context.SaveChanges();
            tmpWarehouse = context.Warehouses.ToList();
            Console.WriteLine("New position / location was added to a warehouse.");
            debugLine = "";

            //try
            //{
            //    // adding a position already existing throws key error
            //    ware = context.Warehouses.ToList()[0];
            //    ware.Locations.Add(new Location() { Position = "pos1" });
            //    context.Warehouses.Update(ware);
            //    context.SaveChanges();
            //}
            //catch (InvalidOperationException e)
            //{
            //    if (e.Message.Contains("same key"))
            //    {
            //        Console.WriteLine("Key pos already exists");
            //    }
            //    else
            //    {
            //        Console.WriteLine(e);
            //    }
                
            //}

            // trying to get only a location
            var loc = context.Locations.ToList()[0];
            debugLine = "";

            // add new pallet to loc
            var pallets = new List<Pallet>()
            {
                new Pallet()
                {
                    Client = clients[0],
                    Content = "Just some content"
                },
                new Pallet()
                {
                    Client = clients[0],
                    Content = "Just some other content"
                }
            };

            // adding pallet to the location
            loc.Pallet = pallets[0];
            context.Locations.Update(loc);
            context.SaveChanges();

            // lets also try add it through warehouse.
            ware = context.Warehouses.ToList()[0];
            ware.Locations.ToList()[0].Pallet = pallets[0];
            context.Warehouses.Update(ware);
            context.SaveChanges();
            
            var tmpLoc = context.Locations.ToList();
            debugLine = "";


            // can we remove the pallet again?

            loc = context.Locations.ToList()[0];
            loc.Pallet = null;
            context.Locations.Update(loc);
            context.SaveChanges();
            tmpLoc = context.Locations.ToList();
            debugLine = "";

            // add one again to make sure the entity holds one pallet atleast
            loc.Pallet = pallets[0];
            context.Locations.Update(loc);
            context.SaveChanges();

            // lets also try add pallet in location directly
            loc = context.Locations.ToList()[1];
            loc.Pallet = pallets[1];
            context.Locations.Update(loc);
            context.SaveChanges();
            

            // add a client to a location
            loc = context.Locations.ToList()[0];
            loc.Client = clients[0];
            context.Locations.Update(loc);
            context.SaveChanges();

            var ware2 = context.Warehouses.ToList()[0];
            ware2.Locations.Add(new Location(){Position = "Pos3"});
            context.Warehouses.Update(ware2);

            var test = context.Locations.ToList();
            var test3 = context.Warehouses.ToList();
            var test2 = test;

            // TODO: Can warehouse be serialized with all sub stuff ?
            var jsonStr = JsonSerializer.Serialize(test3);
            debugLine = "";



        }
    }
}
