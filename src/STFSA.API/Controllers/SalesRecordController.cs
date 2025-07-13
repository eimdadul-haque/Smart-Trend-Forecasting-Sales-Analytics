using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SalesRecordController : ControllerBase
    {
        public SalesRecordController()
        {
        }

        [HttpGet("{datasetId}/records")]
        public async Task<IActionResult> GetRecords(string datasetId)
        {
            return Ok(new { Message = "Get all sales records", DatasetId = datasetId });
        }

        [HttpGet("{datasetId}/records/stats")]
        public async Task<IActionResult> GetRecordsStats(string datasetId)
        {
            return Ok(new { Message = "Summary statistics for sales records", DatasetId = datasetId });
        }

        [HttpGet("{datasetId}/records/download")]
        public async Task<IActionResult> DownloadRecords(string datasetId)
        {
            return Ok(new { Message = "Download raw data as CSV/Excel", DatasetId = datasetId });
        }
    }
}
