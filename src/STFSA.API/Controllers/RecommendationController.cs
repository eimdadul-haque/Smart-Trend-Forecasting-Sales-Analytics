using Microsoft.AspNetCore.Mvc;
using STFSA.Domain.Entities;
using System.Buffers.Text;
using System.Data;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RecommendationController : ControllerBase
    {
        public RecommendationController() { }

        [HttpGet("{datasetId}/recommendations")]
        public IActionResult GetRecommendations(string datasetId)
        {
            return Ok(new { Message = "Recommendations fetched successfully", DatasetId = datasetId });
        }

        [HttpPost("{datasetId}/recommendations/run")]
        public IActionResult RunRecommendations(string datasetId)
        {
            return Ok(new { Message = "Recommendation engine run successfully", DatasetId = datasetId });
        }
    }
}