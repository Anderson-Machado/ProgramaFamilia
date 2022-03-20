using Familia.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Familia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointsController : ControllerBase
    {
        private readonly ILogger<PointsController> _logger;

        private readonly IPointsAppServices _services;

        public PointsController(ILogger<PointsController> logger, IPointsAppServices services)
        {
            _logger = logger;
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetPoints()
        {
            var result = await _services.GetPointsFamily();
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
