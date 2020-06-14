using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Efcore_ExampleWarehouse.Data;
using Efcore_ExampleWarehouse.Entities.example;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Efcore_ExampleWarehouse.Controllers
{
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly CatContext _context;

        public WarehouseController(CatContext context)
        {
            _context = context;
        }


        /***
         * WAREHOUSE
         */
        [HttpGet("/warehouse")]
        public async Task<ActionResult<IEnumerable<Warehouse>>> Warehouse()
        {

            return _context.Warehouses.ToList();

        }

        [HttpGet("/warehouse/locations")]
        public async Task<ActionResult<IEnumerable<Warehouse>>> WarehouseLocations()
        {

            return await _context.Warehouses
                .Include(x => x.Locations)
                .ToListAsync();
        }

        [HttpGet("/warehouse/locations/pallets")]
        public async Task<ActionResult<IEnumerable<Warehouse>>> WarehouseLocationsPallets()
        {

            return await _context.Warehouses
                .Include(x => x.Locations)
                .ThenInclude(x=>x.Pallet)
                .ToListAsync();
        }

        /*
         * LOCATIONS
         */
        [HttpGet("/locations/")]
        public async Task<ActionResult<IEnumerable<Location>>> Locations()
        {

            return await _context.Locations.ToListAsync();
        }

        [HttpGet("/locations/pallets")]
        public async Task<ActionResult<IEnumerable<Location>>> LocationsPallets()
        {

            return await _context.Locations
                .Include(x => x.Pallet)
                .ToListAsync();
        }

        [HttpGet("/locations/pallets_and_clients")]
        public async Task<ActionResult<IEnumerable<Location>>> LocationsPalletsAndClient()
        {

            return await _context.Locations
                .Include(x => x.Pallet)
                .Include(x=>x.Client)
                .ToListAsync();
        }

        [HttpGet("/locations/{username}")]
        public async Task<ActionResult<IEnumerable<Location>>> LocationsWithClient(string username)
        {

            return await _context.Locations.Where(x => x.Client.Username.Equals(username)).ToListAsync();
        }

        [HttpGet("/locations/{username}/pallets")]
        public async Task<ActionResult<IEnumerable<Location>>> LocationsOwnedByClientsWithPallets(string username)
        {

            return await _context.Locations
                .Where(x => x.Client.Username.Equals(username))
                .Include(x=>x.Pallet)
                .ToListAsync();
        }


        /*
         * PALLETS
         */
        [HttpGet("/pallets")]
        public async Task<ActionResult<IEnumerable<Pallet>>> Pallets()
        {
            return await _context.Pallets.ToListAsync();
        }

        [HttpGet("/pallets/client")]
        public async Task<ActionResult<IEnumerable<Pallet>>> PalletsClient()
        {
            return await _context.Pallets
                .Include(x=>x.Client)

                .ToListAsync();
        }

    }
}
