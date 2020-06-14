using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolumeWebService.Data;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Controllers
{
    [ApiController]
    public class VolumeController : ControllerBase
    {
        private readonly VolumeContext _context;
        private readonly Calculator calculator;

        public VolumeController(VolumeContext context, Calculator calculator)
        {
            _context = context;
            this.calculator = calculator;
        }

        [HttpGet]
        [Route("calculate")]
        public async Task<List<VolumeResult>> GetResult()
        {
            return await _context.VolumeResult.ToListAsync();
        }

        // /calculate/cylinder?height=x&radius=y (GET) 
        [HttpGet]
        [Route("calculate/cylinder")]
        public async Task<ActionResult<VolumeResult>> GetCylinderResult(decimal height, decimal radius)
        {
            var calc = new VolumeResult() {Height = height, Radius = radius, Type = "Cylinder", Volume = calculator.CalculateVolumeCylinder(height, radius) };
            return calc;
        }

        // /calculate/cone?height=x&radius=y (GET) 
        [HttpGet]
        [Route("calculate/cone")]
        public async Task<ActionResult<VolumeResult>> GetConeResult(decimal height, decimal radius)
        {
            var calc = new VolumeResult() { Height = height, Radius = radius, Type = "Cone", Volume = calculator.CalculateVolumeCone(height, radius) };
            return calc;
        }


        [HttpPost]
        [Route("calculate/cylinder")]
        public async Task<ActionResult<VolumeResult>> PostCylinder(decimal height, decimal radius)
        {
            var result = new VolumeResult() { Type = "Cylinder", Height = height, Radius = radius, Volume = calculator.CalculateVolumeCylinder(height, radius)};
            _context.VolumeResult.Add(result);
            await _context.SaveChangesAsync();

            return result;
        }

        [HttpPost]
        [Route("calculate/cone")]
        public async Task<ActionResult<VolumeResult>> PostCone(decimal height, decimal radius)
        {
            var result = new VolumeResult() { Type = "Cone", Height = height, Radius = radius, Volume = calculator.CalculateVolumeCone(height, radius) };
            _context.VolumeResult.Add(result);
            await _context.SaveChangesAsync();

            return result;
        }





    }
}
