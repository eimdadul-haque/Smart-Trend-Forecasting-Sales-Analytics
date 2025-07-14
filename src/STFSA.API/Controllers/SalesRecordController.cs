using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/sales")]
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


//| Method | Endpoint | Description |
//| ------ | ---------------------------------------- | ----------------------------------------------- |
//| GET | `/ datasets /{ datasetId}/ records`          | Get all sales records in a dataset              |
//| GET    | `/datasets/{datasetId}/ records / stats`    | Summary statistics(total sales, revenue, etc.) |
//| GET | `/ datasets /{ datasetId}/ records / download` | Download raw data as CSV/Excel                  |

