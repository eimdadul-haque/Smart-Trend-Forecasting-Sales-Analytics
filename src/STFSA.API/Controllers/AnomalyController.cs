using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/anomaly")]
    public class AnomalyController : ControllerBase
    {
        public AnomalyController() { }

        [HttpGet("{datasetId}/anomalies")]
        public async Task<IActionResult> GetAnomaliesAsync(string datasetId)
        {
            return Ok();
        }

        [HttpPost("{datasetId}/anomalies/run")]
        public async Task<IActionResult> RunAnomalyDetectionAsync(string datasetId, bool sync = false)
        {
            return Ok();
        }

        [HttpGet("anomalies/{id}")]
        public async Task<IActionResult> GetAnomalyByIdAsync(string id)
        {
            return Ok();
        }
    }
}


//| Method | Endpoint | Description |
//| ------ | ------------------------------------- | ------------------------- |
//| GET | `/ datasets /{ datasetId}/ anomalies`     | Get detected anomalies    |
//| POST   | `/datasets/{datasetId}/ anomalies / run` | Trigger anomaly detection |
//| GET    | `/anomalies/{id}`                     | Get anomaly details       |

