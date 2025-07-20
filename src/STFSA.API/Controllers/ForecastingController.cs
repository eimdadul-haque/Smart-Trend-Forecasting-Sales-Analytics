using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using System.Data;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/forecasting")]
    public class ForecastingController : ControllerBase
    {
        public ForecastingController() { }

        [HttpPost("{datasetId}/run")]
        public async Task<IActionResult> RunForecastAsync(string datasetId, bool sync = false)
        {
            return Ok();
        }

        [HttpGet("{datasetId}/latest")]
        public async Task<IActionResult> GetLatestForecastAsync(string datasetId)
        {
            return Ok();
        }

        [HttpGet("{datasetId}/history")]
        public async Task<IActionResult> GetForecastHistoryAsync(string datasetId)
        {
            return Ok();
        }

        [HttpGet("{forecastId}")]
        public async Task<IActionResult> GetForecastByIdAsync(string forecastId)
        {
            return Ok();
        }
    }
}