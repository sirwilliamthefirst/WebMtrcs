using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebMtrcs.Models;
using WebMtrcs.Services;

namespace WebMtrcs.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class MetricsController : ControllerBase
    {
        private readonly DatabaseService _databaseService;
        private readonly ILogger<MetricsController> _logger;

        public MetricsController(DatabaseService databaseService, ILogger<MetricsController> logger)
        {
            _databaseService = databaseService;
            _logger = logger;
        }


        [HttpPost]
        public IActionResult PostMetric([FromBody] Metric metric)
        {
            if (metric == null)
            {
                return BadRequest("Metric data is required.");
            }

            _databaseService.SaveMetric(metric);
            // Process the metric (e.g., save to database)
            // Example: SaveToDatabase(metric);

            return Ok(new { Message = "Metric saved successfully!" });
        }

        
    }
}
